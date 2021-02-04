using AdminPanelService.Models;
using Microsoft.EntityFrameworkCore;

namespace AdminPanelService.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> db) : base(db)
        {

        }
    }
}
