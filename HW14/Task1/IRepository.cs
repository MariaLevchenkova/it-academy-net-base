public interface IRepository<T>
{
    List<T> Get();
    T GetById(int id);
    void Add ( T value);
    void Delete(int id);
    void Update(T value);
}

