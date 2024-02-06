using System.ComponentModel.DataAnnotations;

namespace WebApiWithIdentity.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Kullanıcı Adı Gerekli")]
        public string? Username { get; set; }

        [Required(ErrorMessage = "Şifre Adı Gerekli")]
        public string? Password { get; set; }
    }
}
