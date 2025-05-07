using Microsoft.AspNetCore.Identity;

namespace OpenCart.Server.Entity.Models
    {

    public class ApplicationUser: IdentityUser<long>
        {
        public String? FirstName { get; set; }
        public String? LastName { get; set; }
        }
    }
