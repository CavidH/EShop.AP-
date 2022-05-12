using Microsoft.EntityFrameworkCore;

namespace EShopAPİ.Persistence.Contexts
{
    public class EShopDbContext : DbContext
    {
        public EShopDbContext(DbContextOptions options) : base(options)  { }
    }
}
