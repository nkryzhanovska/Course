using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeless8
{
    class MyStack<T>:Buffer<T>, IMyStack<T>
    {
        private int top = 0;
        private int N = 10;
        

        public MyStack(T[] array)
        {
            items = array;
        }

        public override bool IsEmpty()
        {
            return (top == 0);
        }

        public override bool IsFull()
        {
            return (top == N);
        }

        public override T Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Nothing is here!");
                return default(T);
            }
            else
            {
                return items[top - 1];
            }
        }
        
        public void Push(T value)
        {
            if (IsFull())
            {
                Console.WriteLine("Stack is full!");
            }

            else
            {
                items[top] = value;
                Console.WriteLine("Item pushed successfully!");
                top = top + 1;
            }
        }

        public T Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty!");
                return default(T);
            }
            else
            {
                top = top - 1;
                T a = items[top];
                items[top] = default(T);
                return a;
            }
        }
    }
}
