using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Yildirim.Identity.Entitties;

namespace Yildirim.Identity.Context
{
    public class YildirimContext :IdentityDbContext<AppUser,AppRole,int>
    {
        public YildirimContext(DbContextOptions<YildirimContext>options) :base(options)
        {

        }
    }
}
