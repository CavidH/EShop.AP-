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
                .UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=EShopApiDbv1;Trusted_Connection=True;");
            return new(dbContextOptionsBuilder.Options);
        }
    }
}