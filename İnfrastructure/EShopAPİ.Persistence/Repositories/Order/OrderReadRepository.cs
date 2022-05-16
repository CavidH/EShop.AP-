using EShopAPİ.Application.Repositories;
using EShopAPİ.Domain.Entities;
using EShopAPİ.Persistence.Contexts;

namespace EShopAPİ.Persistence.Repositories;

public class OrderReadRepository : ReadRepository<Order>, IOrderReadRepository
{
    public OrderReadRepository(EShopDbContext context) : base(context)
    {
    }
}