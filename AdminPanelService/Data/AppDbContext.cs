using AdminPanelService.Converters;
using AdminPanelService.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Serializer = AdminPanelService.Attributes.SerializerAttribute;

namespace AdminPanelService.Data
{
    public class AppDbContext : DbContext
    {
		public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> db) : base(db)
        {

        }

        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            //{
            //    foreach (var property in entityType.GetProperties())
            //    {
            //        var attributes = property.PropertyInfo.GetCustomAttributes(typeof(Serializer), false);
            //        if (attributes.Any())
            //        {
            //            property.SetValueConverter(new SerializerConverter());
            //        }
            //    }
            //}
        }
    }
}
