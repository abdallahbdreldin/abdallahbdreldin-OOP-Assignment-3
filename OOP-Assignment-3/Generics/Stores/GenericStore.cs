using Generics.Interfaces;
using System.Collections.ObjectModel;

namespace Generics.Stores
{
    public class GenericStore<T> where T : class, IHasId
    {
        private readonly Dictionary<int, T> _items = new();

        public void Add(T item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item), "Item cannot be null.");
            }
            if(_items.ContainsKey(item.Id))
            {
                throw new ArgumentException($"An item with Id {item.Id} already exists.", nameof(item));
            }
            _items.Add(item.Id, item);
        }

        public T? GetById(int id) 
        {
            if (id <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(id), "Id must be greater than zero.");
            }
            
            if(_items.TryGetValue(id, out T? item))
            {
                return item;
            }

            return null;
        }

        public IReadOnlyDictionary<int, T> GetAll()
        {
            return _items;
        }

        public void RemoveById(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(id), "Id must be greater than zero.");
            }
            
            if(!_items.Remove(id))
            {
                throw new KeyNotFoundException($"No item found with Id {id}.");
            }
        }
    }
}
