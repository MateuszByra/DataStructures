using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkedList
{
    public class LinkedListNode<T>
    {
        /// <summary>
        /// Constructs a new node with the specified value
        /// </summary>
        /// <param name="value"></param>
        public LinkedListNode(T value)
        {
            Value = value;
        }

        /// <summary>
        /// The node value
        /// </summary>
        public T Value { get; internal set; }

        /// <summary>
        /// The next node in the linked list (null if last node)
        /// </summary>
        public LinkedListNode<T> Next { get; internal set; }

        /// <summary>
        /// The previous node in the linked list (null if first node)
        /// </summary>
        public LinkedListNode<T> Previous { get; internal set; }


    }
}
