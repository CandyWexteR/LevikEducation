using Microsoft.EntityFrameworkCore;

namespace Templates.RepositorySamples;

public abstract class EntityFrameworkRepository<T> : IRepository<T> where T: class, IdableEntity
{
    private readonly Context _context;
    public readonly DbSet<T> _dbSet;

    public EntityFrameworkRepository(Context context, DbSet<T> dbSet)
    {
        _context = context;
        _dbSet = dbSet;
    }

    public abstract string NotExistsMessage { get; }
    public abstract string AlreadyExistsMessage { get; }

    public async Task Add(T item)
    {
        if (_dbSet.Any(f=>f.Id == item.Id))
            throw new Exception(AlreadyExistsMessage);
        
        _dbSet.Add(item);
        await _context.SaveChangesAsync();
    }

    public async Task Remove(Guid id)
    {
        var entity = await Get(id);
        _dbSet.Remove(entity);
        await _context.SaveChangesAsync();
    }

    public async Task Update(T item)
    {
        _dbSet.Update(item);
        await _context.SaveChangesAsync();
    }

    public async Task<T> Get(Guid id)
    {
        return _dbSet.FirstOrDefault(f => f.Id == id) ?? throw new Exception(NotExistsMessage);
    }
}