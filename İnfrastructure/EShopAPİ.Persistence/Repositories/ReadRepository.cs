using System.Linq.Expressions;
using EShopAPİ.Application.Repositories;
using EShopAPİ.Domain.Entities.Comon;
using EShopAPİ.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace EShopAPİ.Persistence.Repositories;

public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity

{
    private readonly EShopDbContext _context;

    public ReadRepository(EShopDbContext context)
    {
        _context = context;
    }

    public DbSet<T> Table => _context.Set<T>();

    public IQueryable<T> GetAll(bool tracking = true)
    {
        IQueryable<T> query = Table.AsQueryable();
        if (!tracking)
            query.AsNoTracking();
        return query;
    }

    public IQueryable<T> GetWhere(Expression<Func<T, bool>> expression, bool tracking = true)
    {
        IQueryable<T> query = Table.Where(expression);
        if (!tracking)
            query.AsNoTracking();
        return query;
    }

    public async Task<T> GetSingleAsync(Expression<Func<T, bool>> expression, bool tracking = true)
    {
        IQueryable<T> query = Table.AsQueryable();
        if (!tracking)
            query.AsNoTracking();
        return await Table.FirstOrDefaultAsync(expression);
    }

    public async Task<T> GetByIdAsync(string id, bool tracking = true)
        // => await Table.FirstOrDefaultAsync(p => p.İD == Guid.Parse(id));
        => await Table.FindAsync(Guid.Parse(id));
}