using System.Linq.Expressions;
using EShopAPİ.Application.Repositories;
using EShopAPİ.Domain.Entities.Comon;
using EShopAPİ.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace EShopAPİ.Persistence.Repositories;

public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity

{
    private readonly EShopDbContext _context;
    public DbSet<T> Table => _context.Set<T>();

    public IQueryable<T> GetAll() => Table;

    public IQueryable<T> GetWhere(Expression<Func<T, bool>> expression)
        => Table.Where(expression);

    public async Task<T> GetSingleAsync(Expression<Func<T, bool>> expression)
        => await Table.FirstOrDefaultAsync(expression);

    public async Task<T> GetByIdAsync(string id)
        => await Table.FirstOrDefaultAsync(p => p.İD == Guid.Parse(id));
}