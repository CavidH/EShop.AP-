using EShopAPİ.Domain.Entities;
using EShopAPİ.Domain.Entities.Comon;
using Microsoft.EntityFrameworkCore;

namespace EShopAPİ.Persistence.Contexts
{
    public class EShopDbContext : DbContext
    {
        public EShopDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }


        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            var datas = ChangeTracker
                .Entries<BaseEntity>();
            foreach (var data in datas)
            {
                _ = data.State switch // datani tutmuruq
                {
                    EntityState.Added => data.Entity.CreatedDate = DateTime.Now,
                    EntityState.Modified => data.Entity.UpdatedDates = DateTime.Now
                };
            }

            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}