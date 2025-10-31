using Microsoft.AspNetCore.Identity;

namespace Company_System.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? FullName { get; set; }
    }
}
