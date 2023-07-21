using Microsoft.AspNetCore.Identity;

namespace Yildirim.Identity.Entitties
{
    public class AppUser :IdentityUser<int>
    {
        public string ImagePath { get; set; }
        public string Gender { get; set; }
    }
}
