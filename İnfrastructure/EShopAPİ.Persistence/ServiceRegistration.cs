using EShopAPİ.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace EShopAPİ.Persistence
{
    public static class ServiceRegistration
    { 
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<EShopDbContext>(options => options
                .UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=EShopApiDbv1;Trusted_Connection=True;"));
        }
    }
}
