using System.ComponentModel.DataAnnotations;

namespace MOCDEMSNEW.Models.ViewModel
{
    public class EnableAuthenticatorViewModel
    {
        [Required]
        [StringLength(7, MinimumLength = 6)]
        [DataType(DataType.Text)]
        [Display(Name = "Verification Code")]
        public string SharedKey { get; set; } = "";

        public string AuthenticatorUri { get; set; } = "";

        public string VerificationCode { get; set; } = "";

    }
}
