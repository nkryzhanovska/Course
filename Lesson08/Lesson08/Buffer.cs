using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeless8
{
    public abstract class Buffer<T>:IBuffer<T>
    {
        protected T[] items;


        public abstract bool IsEmpty();
        public abstract bool IsFull();

        public abstract T Peek();

        public void Print()
        {
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine("Array Element {0} = {1}", i + 1, items[i]);
            }
        }
    }
}
