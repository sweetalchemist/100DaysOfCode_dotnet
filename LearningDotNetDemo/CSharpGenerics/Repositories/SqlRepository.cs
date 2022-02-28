using CSharpGenerics.Entities;
using Microsoft.EntityFrameworkCore;

namespace CSharpGenerics.Repositories
{
    public class SqlRepository<T> : IRepository<T> where T : EntityBase
    {
        private readonly DbContext _dbContext;
        private readonly DbSet<T> _dbSet;

        public SqlRepository(DbContext dbContext)
        {
            this._dbContext = dbContext;
            this._dbSet = _dbContext.Set<T>();
        }
        public T GetById(int id) => _dbSet.Find(id);
        public void Add(T item)
        {
            _dbSet.Add(item);
        }

        public void Remove(T item)
        {
            _dbSet.Remove(item);
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }
    }
}
