using System.ComponentModel.DataAnnotations;

namespace MOCDEMSNEW.Models.ViewModel
{
    public class SetupTwoFactorViewModel
    {
        // Shown as QR code for scanning in authenticator app

        public string QRCodeImage { get; set; } = "";

        // otpauth:// URI (can also be displayed as link or hidden field)
        public string AuthenticatorUri { get; set; } = "";

        // Recovery codes for backup login
        public List<string> RecoveryCodes { get; set; } = new List<string>();

        // User input: 6-digit verification code from authenticator app
        [Required]
        [StringLength(7, MinimumLength = 6)]
        [DataType(DataType.Text)]
        [Display(Name = "Verification Code")]
        public string VerificationCode { get; set; } = "";
    }
}
