using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkwork
{
    public abstract class Buffer<T> : IBuffer<T>
    {
        protected MyLinkedList<T> list;

        public abstract bool IsEmpty();
        public abstract bool IsFull();

        public abstract T Peek();

        public abstract void Print();
        
    }
}
