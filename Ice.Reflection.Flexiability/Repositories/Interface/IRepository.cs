using System.Collections.Generic;
namespace Ice.Reflection.Flexiability.Repositories.Interface
{
    public interface IRepository<T>
    {
        IEnumerable<T> ReadAll();
        T Get(int id);
        T Update(T entity, int id);
        T Add(T entity);

        T Delete(int id);
    }
}