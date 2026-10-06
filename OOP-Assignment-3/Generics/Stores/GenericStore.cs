using Generics.Entities;

namespace Generics.Stores
{
    public class GenericStore<T> where T : class
    {
        private readonly List<T> _items = new();

        public void Add(T item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item), "Item cannot be null.");
            }
            _items.Add(item);
        }

        public T? GetById(int id) 
        {
            if (id <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(id), "Id must be greater than zero.");
            }
            for (int i = 0; i < _items.Count; i++)
            {
                if (_items[i].Id == id)
                {
                    return _items[i];
                }
            }
            return null;
        }

        public IReadOnlyList<T> GetAll()
        {
            foreach (var item in _items)
            {
                if (item == null)
                {
                    throw new InvalidOperationException("Item list contains a null entry.");
                }
            }
            return _items;
        }

        public void RemoveById(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(id), "Id must be greater than zero.");
            }
            for (int i = 0; i < _items.Count; i++)
            {
                if (_items[i].Id == id)
                {
                    _items.RemoveAt(i);
                    return;
                }
            }
        }
    }
}
