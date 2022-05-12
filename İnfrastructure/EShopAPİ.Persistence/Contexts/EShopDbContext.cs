using EShopAPİ.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EShopAPİ.Persistence.Contexts
{
    public class EShopDbContext : DbContext
    {
        public EShopDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }



    }
}
