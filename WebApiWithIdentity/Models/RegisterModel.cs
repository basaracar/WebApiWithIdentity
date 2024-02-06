using System.ComponentModel.DataAnnotations;

namespace WebApiWithIdentity.Models
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Kullanıcı Adı gerekli")]
        public string? Username { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "Email gerekli")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Şifre gerekli")]
        public string? Password { get; set; }
    }
}
