using TastyShopApp.Models;
using Microsoft.EntityFrameworkCore;

namespace TastyShopApp.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options): base(options)
        {
        }

        public DbSet<Category> Category { get; set; }
        public DbSet<Manager> Manager { get; set; }
        public DbSet<Product> Product { get; set; }
    }
}
