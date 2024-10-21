using Microsoft.EntityFrameworkCore;
using SellphoneC.Models;

namespace SellphoneC.Services
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) 
        {
        
        }

        public DbSet<Product> Products { get; set; }
    }
}
