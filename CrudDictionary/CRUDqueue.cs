using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudDictionary
{
    internal class CRUDqueue<T>
    {
        public Queue<T> _queue;

        public CRUDqueue()
        {
            _queue = new Queue<T>();
        }

        public void Create(T item)
        {
            _queue.Enqueue(item);
        }

        public IEnumerable<T> Read()
        {
            return _queue.ToList();
        }

        public T Read(int index)
        {
            if (index < 0 || index >= _queue.Count)
                throw new ArgumentOutOfRangeException(nameof(index), "Index out of range");

            return _queue.ElementAt(index);
        }

        public void Update(int index, T newItem)
        {
            if (index < 0 || index >= _queue.Count)
                throw new ArgumentOutOfRangeException(nameof(index), "Index out of range");

            var list = _queue.ToList();
            list[index] = newItem;
            _queue = new Queue<T>(list);
        }

        public void Delete(int index)
        {
            if (index < 0 || index >= _queue.Count)
                throw new ArgumentOutOfRangeException(nameof(index), "Index out of range");

            var list = _queue.ToList();
            list.RemoveAt(index);
            _queue = new Queue<T>(list);
        }
    }
}
