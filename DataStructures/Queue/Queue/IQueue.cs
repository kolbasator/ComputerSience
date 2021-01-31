using System;
using System.Collections.Generic;
using System.Text;

namespace Queue
{
    public  interface IQueue<T>
    {
        /// <summary>
        /// Property verifies that queue is empty.
        /// </summary>
        bool IsEmpty { get; }

        /// <summary>
        /// Property verifies that queue is full.
        /// </summary>
        bool IsFull { get; }

        /// <summary>
        /// Returns the number of elements in queue
        /// </summary>
        int Count { get; }

        /// <summary>
        /// Adds item to the end of the queue.
        /// </summary>
        void Enqueue(T entity);

        /// <summary>
        /// Pops item from the top of the queue and gives pointer to it.
        /// </summary>
        T Dequeue();

        /// <summary>
        /// Returns the top element of the queue without removing from queue.
        /// </summary>
        T Peek();
    }
}
