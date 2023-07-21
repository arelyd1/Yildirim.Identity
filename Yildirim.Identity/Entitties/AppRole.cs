using Microsoft.AspNetCore.Identity;
using System;

namespace Yildirim.Identity.Entitties
{
    public class AppRole:IdentityRole<int>
    {
        public DateTime CratedTime { get; set; }
    }
}
