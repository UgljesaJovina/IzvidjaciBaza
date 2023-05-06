namespace Repositories.Interfaces;

public interface IRepository<T> where T : class
{
    ICollection<T> GetAll();
    T? GetById(Guid id);
    T? Create(T? obj);
    T? Update(Guid id, T? obj);
    bool Delete(Guid id);
    void Save();
}