using SellphoneC.Models;
using Microsoft.EntityFrameworkCore;

namespace SellphoneC.Services
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions option) : base(option)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
