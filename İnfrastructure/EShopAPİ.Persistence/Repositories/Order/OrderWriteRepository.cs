using EShopAPİ.Application.Repositories;
using EShopAPİ.Domain.Entities;
using EShopAPİ.Persistence.Contexts;

namespace EShopAPİ.Persistence.Repositories;

public class OrderWriteRepository : WriteRepository<Order>, IOrderWriteRepository
{
    public OrderWriteRepository(EShopDbContext context) : base(context)
    {
    }
}