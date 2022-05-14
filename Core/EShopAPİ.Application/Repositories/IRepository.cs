using Microsoft.EntityFrameworkCore;

namespace EShopAPİ.Application.Repositories;

public interface IRepository<T> where T : class
{
    DbSet<T> Table { get; }
}