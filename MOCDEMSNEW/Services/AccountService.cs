using MOCDEMSNEW.Models;
using MOCDEMSNEW.Repository;

namespace MOCDEMSNEW.Services
{
    public class AccountService: IAccountService
    {

        private readonly IEmployeeTwoFactorRepository _twoFactorRepository;

        private readonly ITwoFactorService _twoFactorService;

        private readonly IUserRepository _userRepository;

        public AccountService(IEmployeeTwoFactorRepository twoFactorRepository, ITwoFactorService twoFactorService, IUserRepository userRepository)
        {
            _twoFactorRepository = twoFactorRepository;
            _twoFactorService = twoFactorService;
            _userRepository = userRepository;
        }

        public async Task EnableTwoFactorAsync(int empId)
        {
            var twoFactor = await _twoFactorRepository.GetByEmployeeIdAsync(empId);
            if (twoFactor != null)
            {
                twoFactor.IsEnabled = true;
                await _twoFactorRepository.UpdateAsync(twoFactor);
            }
        }

        public string GenerateQrCodeUri(string secret, string email)
        {
            return _twoFactorService.GenerateQrCodeUri(secret, email);
        }

        public async Task<string> GenerateSecretAsync(int empId)
        {
            var twoFactor = await _twoFactorRepository.GetByEmployeeIdAsync(empId);
            if (twoFactor != null) return twoFactor.SecretKey;

            var secret = _twoFactorService.GenerateSecret();
            await _twoFactorRepository.AddAsync(new EmployeeTwoFactor
            {
                EmployeeId = empId,
                SecretKey = secret,
                IsEnabled = true
            });

            return secret;
        }

        public async Task<bool> VerifyTwoFactorAsync(int empId, string code)
        {
            var twoFactor = await _twoFactorRepository.GetByEmployeeIdAsync(empId);

            if (twoFactor == null || !twoFactor.IsEnabled)
            {
                return false;
            }
            return _twoFactorService.ValidateCode(twoFactor.SecretKey, code);
        }

    }
}
