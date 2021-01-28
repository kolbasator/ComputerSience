using System;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    public class StackViaArray<T> : IStack<T>
    {
        public int Count { get; }
        public bool IsEmpty { get; }

        public T[] Items;

        public StackViaArray(int length)
        {
            Items = new T[length];
        }


        public void Push(T entity)
        {
            if (Count == Items.Length)
                throw new InvalidOperationException("Переполнение стека");
            int index = Count;
            Items[index++] = entity;
        }
        public T Peek()
        {
            return Items[Count - 1];
        }
        public T Pop()
        {
            if (IsEmpty)
                throw new InvalidOperationException("Стек пуст");
            int index = Count; 
            T item = Items[index--];
            Items[Count] = default(T);  
            return item;
        }

    }
}
