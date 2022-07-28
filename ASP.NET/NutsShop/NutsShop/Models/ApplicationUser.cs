using Microsoft.AspNetCore.Identity;

namespace NutsShop.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
    }
}
