using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Queue
{
    public class Queue<T>
    {
        LinkedList.LinkedList<T> _items = new LinkedList.LinkedList<T>();

        public void Enqueue(T value)
        {
            _items.AddFirst(value);
        }

        public T Dequeue()
        {
            if (_items.Count == 0)
            {
                throw new InvalidOperationException("This queue is empty.");
            }
            T last = _items.Tail.Value;
            _items.RemoveLast();
            return last;
        }

        public T Peek()
        {
            if (_items.Count == 0)
            {
                throw new InvalidOperationException("This queue is empty.");
            }
            return _items.Tail.Value;
        }

        public int Count
        {
            get
            {
                return _items.Count;
            }
        }
    }
}
