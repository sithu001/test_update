using OtpNet;

namespace MOCDEMSNEW.Services
{
    public class TwoFactorService:ITwoFactorService
    {

        public string GenerateSecret()
        {
            var bytes = KeyGeneration.GenerateRandomKey(20);
            return Base32Encoding.ToString(bytes);
        }

        public string GenerateQrCodeUri(string secret, string email, string issuer = "DEMS")
        {
            return $"otpauth://totp/{issuer}:{email}?secret={secret}&issuer={issuer}&digits=6";
        }


        public bool ValidateCode(string secret, string code)
        {

            if (string.IsNullOrWhiteSpace(secret)) return false;
            if (string.IsNullOrWhiteSpace(code)) return false;

            // normalize code to digits only
            code = code.Replace(" ", "").Replace("-", "").Trim();

            try
            {
                var bytes = Base32Encoding.ToBytes(secret);
                var totp = new Totp(bytes);
                return totp.VerifyTotp(code, out long _, new VerificationWindow(2, 2));
            }
            catch
            {
                // If Base32Parsing or Totp creation fails, treat as invalid
                return false;
            }
        }
    }
}
