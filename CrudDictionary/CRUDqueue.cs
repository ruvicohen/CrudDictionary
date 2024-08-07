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
        private Queue<T> myQueue = new Queue<T>();

        public void Clear()
        {
            myQueue.Clear();
        }

        public void Enqueue(T value)
        {
            myQueue.Enqueue(value);
        }

        public T Dequeue()
        {
            return myQueue.Dequeue();
        }

        public T Peek()
        {
            return myQueue.Peek();
        }
    }
}
