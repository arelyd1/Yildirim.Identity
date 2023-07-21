using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Yildirim.Identity.Models
{
    public class RoleCreateModel
    {
        [Required(ErrorMessage ="Ad alanı gereklidir.")]
        public string Name { get; set; }
    }
}
