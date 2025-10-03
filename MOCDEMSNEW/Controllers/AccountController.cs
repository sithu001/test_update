using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MOCDEMSNEW.Data;
using MOCDEMSNEW.Models.ViewModel;
using MOCDEMSNEW.Models;
using OtpNet;
using System.Security.Claims;
using MOCDEMSNEW.Services;

namespace MOCDEMSNEW.Controllers
{
    public class AccountController : Controller
    {
       
        private readonly IAccountService _accountService;

        private readonly DemsContext _context;

        private readonly ITwoFactorService _twoFactorService;


        public AccountController(DemsContext context, ITwoFactorService twoFactorService)
        {
            _context = context;
            _twoFactorService = twoFactorService;
        }

        [HttpGet]
        public IActionResult AccessDenied()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View(new LoginViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
           
            if (!ModelState.IsValid) return View(model);

            var user = _context.Employees
                .FirstOrDefault(u => u.EEmail == model.Email
                                  && u.EPassword == model.Password
                                  && u.EActive == true);

            if (user == null)
            {
                ModelState.AddModelError("", "Invalid email or password.");
                return View(model);
            }

            // 🔹 Check subdomain vs role
            var host = HttpContext.Request.Host.Host.ToLower();

            if (host.StartsWith("admin."))
            {
                // If accessing admin subdomain but user is not admin → AccessDenied
                if (user.EIsAdmin != 1)
                    return RedirectToAction("AccessDenied");
            }
            else
            {
                // If accessing normal domain but user is admin → redirect to admin subdomain login
                if (user.EIsAdmin == 1)
                {
                    string adminHost = $"https://admin.localhost:{HttpContext.Request.Host.Port}/Account/Login";
                    return Redirect(adminHost);
                }
            }

            
            var employee2FA = _context.EmployeeTwoFactors
                .FirstOrDefault(t => t.EmployeeId == user.EId && t.IsEnabled);

            if (employee2FA != null)
            {
                TempData["UserId2FA"] = user.EId;
                TempData["RememberMe"] = model.RememberMe;
                return RedirectToAction("LoginWithTwoFactor");
            }
            else
            {
                TempData["UserIdSetup2FA"] = user.EId;
                TempData["RememberMe"] = model.RememberMe;
                return RedirectToAction("SetupTwoFactor");
            }

            await SignInUser(user, model.RememberMe);

            // Redirect as usual
            return RedirectToAction("Index", "Home");

        }

        private async Task SignInUser(Employee user, bool rememberMe)
        {

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.EFullname ?? user.EName ?? user.EEmail),

                new Claim(ClaimTypes.Email, user.EEmail ?? ""),

                new Claim("EId", user.EId.ToString()),

                new Claim(ClaimTypes.Role, user.EIsAdmin == 1 ? "Admin" : "User")
            };

            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var principal = new ClaimsPrincipal(claimsIdentity);

            var authProperties = new AuthenticationProperties
            {
                //IsPersistent = rememberMe,
                IsPersistent = false,
                AllowRefresh = true
                //ExpiresUtc = DateTimeOffset.UtcNow.AddHours(1)
            };

            // Sign in with the default cookie scheme
            await HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                principal,
                authProperties);

        }

        [HttpGet]
        public IActionResult SetUpTwoFactor()
        {
            if (TempData["UserIdSetup2FA"] == null)
            {
                // No user id → redirect to login
                return RedirectToAction("Login");
            }

            int userId = (int)TempData["UserIdSetup2FA"];

            // Keep TempData for POST
            TempData.Keep("UserIdSetup2FA");

            TempData.Keep("RememberMe");

            var user = _context.Employees.FirstOrDefault(u => u.EId == userId );
            if (user == null)
            {
                return RedirectToAction("Login");
            }

            var twoFactor = _context.EmployeeTwoFactors.FirstOrDefault(t => t.EmployeeId == userId);
            if (twoFactor == null)
            {
                var secretKeyBytes = KeyGeneration.GenerateRandomKey(20);

                twoFactor = new EmployeeTwoFactor
                {
                    EmployeeId = userId,
                    SecretKey = Base32Encoding.ToString(secretKeyBytes),
                    IsEnabled = false,
                    CreatedDate = DateTime.UtcNow
                };
                _context.EmployeeTwoFactors.Add(twoFactor);
                _context.SaveChanges();
            }

            // Generate otpauth URI
            var authenticatorUri = $"otpauth://totp/DEMS:{user.EEmail}?secret={twoFactor.SecretKey}&issuer=DEMS";

            // Generate QR code image
            var qrGenerator = new QRCoder.QRCodeGenerator();
            var qrCodeData = qrGenerator.CreateQrCode(authenticatorUri, QRCoder.QRCodeGenerator.ECCLevel.Q);
            var qrCode = new QRCoder.Base64QRCode(qrCodeData);
            var qrCodeImage = "data:image/png;base64," + qrCode.GetGraphic(5);

            // Generate recovery codes
            var recoveryCodes = new List<string>();
            for (int i = 0; i < 10; i++)
            {
                recoveryCodes.Add(Guid.NewGuid().ToString("N").Substring(0, 8));
            }
            TempData["RecoveryCodes"] = recoveryCodes;

            var model = new SetupTwoFactorViewModel
            {
                QRCodeImage = qrCodeImage,
                AuthenticatorUri = authenticatorUri,
                RecoveryCodes = recoveryCodes
            };
            // TempData["UserIdSetup2FA"] = employeeId; // store user ID for POST
            return View(model);
        }


        [HttpPost]
        public IActionResult ConfirmTwoFactor(string verificationCode)
        {
            if (TempData["UserIdSetup2FA"] == null)
                return RedirectToAction("Login");

            int userId = (int)TempData["UserIdSetup2FA"];

            var twoFactor = _context.EmployeeTwoFactors.FirstOrDefault(t => t.EmployeeId == userId);

            if (twoFactor == null)
                return RedirectToAction("Login");

            // Verify TOTP code
            var totp = new OtpNet.Totp(Base32Encoding.ToBytes(twoFactor.SecretKey));
            bool isValid = totp.VerifyTotp(verificationCode, out _, new OtpNet.VerificationWindow(2, 2));

            if (isValid)
            {
                // Enable 2FA for user
                twoFactor.IsEnabled = true;

                // Retrieve recovery codes safely from TempData
                var recoveryCodesArray = TempData["RecoveryCodes"] as string[];
                var recoveryCodes = recoveryCodesArray?.ToList() ?? new List<string>();

                // Save recovery codes as a single comma-separated string
                twoFactor.RecoveryCodes = string.Join(",", recoveryCodes);

                _context.SaveChanges();

                return RedirectToAction("Index", "Home");
            }

            ModelState.AddModelError("", "Invalid verification code. Please try again.");

            // Keep TempData values for retry
            TempData.Keep("UserIdSetup2FA");
            TempData.Keep("RecoveryCodes");

            return View("SetupTwoFactor");
        }

        // GET 2FA page
        [HttpGet]
        public IActionResult LoginWithTwoFactor()
        {

            if (!TempData.ContainsKey("UserId2FA"))
                return RedirectToAction("Login");

            var vm = new LoginWithTwoFactorViewModel
            {
                UserId = (int)TempData.Peek("UserId2FA"),

                RememberMe = (bool)TempData.Peek("RememberMe")
            };

            // Keep TempData for another request in case needed
            TempData.Keep("UserId2FA");
            TempData.Keep("RememberMe");

            return View(vm);
        }

        // POST 2FA verification
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LoginWithTwoFactor(LoginWithTwoFactorViewModel model)
        {

            if (!ModelState.IsValid)
                return View(model);

            var user = _context.Employees.FirstOrDefault(u => u.EId == model.UserId);
            if (user == null)
            {
                ModelState.AddModelError("", "User not found.");
                return View(model);
            }

            var employee2FA = _context.EmployeeTwoFactors
                .FirstOrDefault(t => t.EmployeeId == model.UserId && t.IsEnabled);

            if (employee2FA == null || !_twoFactorService.ValidateCode(employee2FA.SecretKey, model.TwoFactorCode))
            {
                ModelState.AddModelError("", "Invalid 2FA code.");
                return View(model);
            }

            await SignInUser(user, model.RememberMe);

            TempData.Remove("UserId2FA");
            TempData.Remove("RememberMe");

            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login");
        }
    }
}
