using System;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    public class StackViaArray<T> : IStack<T>
    {
        public T[] array;
        public bool IsEmpty => Count == 0;

        public bool IsFull => Count == array.Length;

        public int Count {get;private set; }
         

        public StackViaArray(int length)
        {
            array = new T[length];
        }


        public void Push(T entity)
        {
            if (IsFull)
                throw new InvalidOperationException("Переполнение стека"); 
            array[Count] = entity;
            Count++;
        }
        public T Peek()
        {
            return array[Count - 1];
        }
        public T Pop()
        {
            if (IsEmpty)
                throw new IndexOutOfRangeException("Stack is empty."); 
            var index =  --Count; 
            var item = array[index];
            array[index ]=default;  
            return item;
        }

    }
}
