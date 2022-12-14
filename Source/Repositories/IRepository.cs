namespace Source.Repositories;

public interface IRepository<T>
{
    //IQueryable<T> GetList(); for Database
    //IEnumerable<T> GetList();
    
    T? Get(Func<T, bool> predicate);
    List<T>? GetList(Func<T, bool>? predicate = null);

    void Add(T entity);
    void Update(T entity);
    void Remove(T entity);
}