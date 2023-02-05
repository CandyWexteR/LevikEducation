namespace Templates.RepositorySamples;

public interface IRepository<T> where T : IdableEntity
{
    public Task Add(T item);
    public Task Remove(Guid id);
    public Task Update(T item);
    public Task<T> Get(Guid id);
}