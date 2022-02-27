using CSharpGenerics.Entities;

namespace CSharpGenerics.Repositories
{
    public interface IRepository<T> where T : EntityBase
    {
        void Add(T item);
        T GetById(int id);
        void Remove(T item);
        void Save();
    }
}