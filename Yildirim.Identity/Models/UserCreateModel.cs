using System.ComponentModel.DataAnnotations;

namespace Yildirim.Identity.Models
{
    public class UserCreateModel
    {
        

        [Required(ErrorMessage ="Kullanıcı adı gereklidir.")]
        public string Username { get; set; }
        [EmailAddress(ErrorMessage ="Lütfen bir email formati giriniz")]
        [Required(ErrorMessage ="Email adresi gereklidir")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Parola alanı gerekldir")]
        public string Password { get; set; }
        [Compare("Password",ErrorMessage = "Parolalar eşleşmiyor.")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage ="Gender gereklidir.")]
        public string Gender { get; set; }
    }
}
