using System;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    public interface IStack<T>
    {
        int Count { get; }
        bool IsEmpty { get; }
        void Push(T entity);
        T Pop();
        T Peek();
    }
}
