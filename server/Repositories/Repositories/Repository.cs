using Repositories.Interfaces;
using Repositories.DAL;
using Microsoft.EntityFrameworkCore;

namespace Repositories.Repositories;

public abstract class Repository<T> : IRepository<T> where T : class
{
    protected DataContext ctx;
    protected DbSet<T> table;

    public Repository(DataContext _ctx)
    {
        ctx = _ctx;
        table = ctx.Set<T>();
    }

    public virtual bool Delete(Guid id)
    {
        T? item = table.Find(id);

        if (item is null) return false;

        table.Remove(item);
        Save();
        return true;
    }

    public virtual ICollection<T> GetAll()
    {
        return table.ToList();
    }

    public virtual T? GetById(Guid id)
    {
        return table.Find(id);
    }

    public virtual T? Create(T? obj)
    {
        if (obj is null) return null;

        table.Add(obj);
        Save();
        return obj;
    }

    public void Save()
    {
        ctx.SaveChanges();
    }

    public virtual T? Update(Guid id, T? obj)
    {
        T? instance = table.Find(id);
        if (instance is null) return null;

        instance = obj;
        Save();
        return instance;
    }
}