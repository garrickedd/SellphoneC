using SellphoneC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace SellphoneC.Services
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions option) : base(option)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
