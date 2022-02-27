using CSharpGenerics.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGenerics.Repositories
{
    public class ListRepository<T> where T : EntityBase
    {
        protected readonly List<T> _items = new();


        public T GetById(int id) => _items.Single(item => item.Id == id);
        public void Add(T item)
        {
            item.Id = _items.Count + 1;
            _items.Add(item);
        }

        public void Remove(T item)
        {
            _items.Remove(item);
        }

        public void Save()
        {
            foreach (var item in _items)
            {
                Console.WriteLine(item);
            }
        }

    }
}
