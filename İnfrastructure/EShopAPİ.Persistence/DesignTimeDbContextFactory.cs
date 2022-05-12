using EShopAPİ.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace EShopAPİ.Persistence
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<EShopDbContext>
    {
        public EShopDbContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<EShopDbContext> dbContextOptionsBuilder = new();
            dbContextOptionsBuilder
                .UseSqlServer(Configurations.GetConnectionString());
            return new(dbContextOptionsBuilder.Options);
        }
    }
}