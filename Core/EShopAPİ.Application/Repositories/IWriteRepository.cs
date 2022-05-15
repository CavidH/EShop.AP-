using EShopAPİ.Domain.Entities.Comon;

namespace EShopAPİ.Application.Repositories;

public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity
{
    Task<bool> AddAsync(T model);
    Task<bool> AddRangeAsync(List<T> datas);
    bool Remove(T model);
    bool Remove(List<T> datas);
    Task<bool> RemoveAsync(string Id);
    bool Update(T model);
    Task SaveAsync();
}