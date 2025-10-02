using System.ComponentModel.DataAnnotations;

namespace MOCDEMSNEW.Models.ViewModel
{
    public class LoginWithTwoFactorViewModel
    {
        [Required]
        [StringLength(7, MinimumLength = 6)]
        [DataType(DataType.Text)]
        [Display(Name = "Authenticator code")]
        public string TwoFactorCode { get; set; } = "";

        public bool RememberMe { get; set; }

        [Display(Name = "Remember this machine")]
        public bool RememberMachine { get; set; }

        public int UserId { get; set; }
    }
}
