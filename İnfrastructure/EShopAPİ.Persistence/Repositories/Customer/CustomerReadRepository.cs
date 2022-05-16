using EShopAPİ.Application.Repositories;
using EShopAPİ.Domain.Entities;
using EShopAPİ.Persistence.Contexts;

namespace EShopAPİ.Persistence.Repositories;

public class CustomerReadRepository : ReadRepository<Customer>, ICustomerReadRepository
{
    public CustomerReadRepository(EShopDbContext context) : base(context)
    {
    }
}