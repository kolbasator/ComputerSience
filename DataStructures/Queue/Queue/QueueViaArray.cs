using System;
using System.Collections.Generic;
using System.Text;

namespace Queue
{
    public class QueueViaArray<T> : IQueue<T>
    {
        public int Count { get; private set; }

        private int _head;

        private int _tail;

        public bool IsEmpty => Count == 0;

        private T[] _items;

        public bool IsFull => Count == _items.Length;

        public QueueViaArray(int length)
        {
            if (length < 0)
                throw new InvalidOperationException("Invalid length.");
            _items = new T[length];
            _head = 0;
            _tail = 0;
        }
        public T Peek()
        {
            if (IsEmpty)
                throw new IndexOutOfRangeException("Queue is empty.");
            return _items[_head];
        }

        public T Dequeue()
        {
            if (IsEmpty)
                throw new IndexOutOfRangeException("Queue is empty.");
            T entity = _items[_head];
            _items[_head] = default;
            _head = (_head + 1) % _items.Length;
            Count--;
            return entity;
        }

        public void Enqueue(T entity)
        {
            if (IsFull)
                throw new IndexOutOfRangeException("Queue is full.");
            _items[_tail] = entity;
            _tail = (_tail + 1) % _items.Length;
            Count++;

        }

    }
}
