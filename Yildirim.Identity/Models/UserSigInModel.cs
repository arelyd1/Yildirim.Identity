using System.ComponentModel.DataAnnotations;
using System.Runtime;

namespace Yildirim.Identity.Models
{
    public class UserSigInModel
    {
        [Required(ErrorMessage="Kullanıcı adı giriniz")]
        public string Username { get; set; }
        [Required(ErrorMessage ="Paralo gereklidir ")]
        public string Password{ get; set; }
        public bool RememberMe { get; set; }
        
        public string ReturnUrl { get; set; }
    }
}
