using System.ComponentModel.DataAnnotations;

namespace AMvcCoreProjeKampi.Models
{
    public class UserSignInModel
    {
        [Required(ErrorMessage ="Lütfen Kullanıcı Adı Giriniz")]
        public string username { get; set; }
        [Required(ErrorMessage = "Lütfen Şifre Giriniz")]
        public string password { get; set; }
    }
}
