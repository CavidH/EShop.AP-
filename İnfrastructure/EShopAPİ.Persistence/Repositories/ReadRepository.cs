using System.Linq.Expressions;
using EShopAPİ.Application.Repositories;
using EShopAPİ.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace EShopAPİ.Persistence.Repositories;

public class ReadRepository<T> : IReadRepository<T> where T : class

{
    private readonly EShopDbContext _context;
    public DbSet<T> Table => _context.Set<T>();

    public IQueryable<T> GetAll() => Table;

    public IQueryable<T> GetWhere(Expression<Func<T, bool>> expression)
    {
        throw new NotImplementedException();
    }

    public Task<T> GetSingleAsync(Expression<Func<T, bool>> expression)
    {
        throw new NotImplementedException();
    }

    public Task<T> GetByIdAsync(string id)
    {
        throw new NotImplementedException();
    }
}