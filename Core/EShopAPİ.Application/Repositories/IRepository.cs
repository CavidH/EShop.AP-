using EShopAPİ.Domain.Entities.Comon;
using Microsoft.EntityFrameworkCore;

namespace EShopAPİ.Application.Repositories;

public interface IRepository<T> where T : BaseEntity
{
    DbSet<T> Table { get; }
}