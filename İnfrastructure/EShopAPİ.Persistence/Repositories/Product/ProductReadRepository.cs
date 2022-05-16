using EShopAPİ.Application.Repositories;
using EShopAPİ.Domain.Entities;
using EShopAPİ.Persistence.Contexts;

namespace EShopAPİ.Persistence.Repositories;

public class ProductReadRepository : ReadRepository<Product>, IProductReadRepository
{
    public ProductReadRepository(EShopDbContext context) : base(context)
    {
    }
}