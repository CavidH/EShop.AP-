using EShopAPİ.Application.Repositories;
using EShopAPİ.Domain.Entities;
using EShopAPİ.Persistence.Contexts;

namespace EShopAPİ.Persistence.Repositories;

public class ProductWriteRepository : WriteRepository<Product>, IProductrWriteRepository
{
    public ProductWriteRepository(EShopDbContext context) : base(context)
    {
    }
}