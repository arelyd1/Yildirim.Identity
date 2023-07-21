using System.ComponentModel.DataAnnotations;

namespace Yildirim.Identity.Models
{
    public class UserAdminCreateModel
    {
        [Required(ErrorMessage = "Kullanıcı adı giriniz")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Email gereklidir ")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Cinsiyet gereklidir ")]
        public string Gender { get; set; }
    }
}
