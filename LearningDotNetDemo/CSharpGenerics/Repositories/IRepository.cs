using CSharpGenerics.Entities;

namespace CSharpGenerics.Repositories
{

    public interface IReadRepository<out T> where T : IEntity
    {
        IEnumerable<T> GetAll();
        T GetById(int id);

    }

    public interface IWriteRepository<in T> where T : IEntity
    {
        void Add(T item);
        void Remove(T item);
        void Save();
    }
    public interface IRepository<T> : IReadRepository<T>, IWriteRepository<T> where T : IEntity
    {
       
        
    }
}