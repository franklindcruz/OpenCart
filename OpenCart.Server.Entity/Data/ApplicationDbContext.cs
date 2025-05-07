using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OpenCart.Server.Entity.Models;

namespace OpenCart.Server.Entity.Data
    {
    public class ApplicationDbContext: IdentityDbContext<ApplicationUser,IdentityRole<long>,long>
        {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
            {
            }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Category> Categories { get; set; }

        }
    }
