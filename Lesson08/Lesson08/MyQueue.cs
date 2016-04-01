using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeless8
{
    class MyQueue<T> : Buffer<T>, IMyQueue<T>
    {
        private int N = 10;
        private int head = -1;
        private int tail = -1;

        public MyQueue(T[] array)
        {
            items = array;
        }
        
        
        public void Enqueue(T value)
        {
            if (IsFull())
            {
                Console.WriteLine("Queue is full!");
            }

            else
            {
                if ((tail == -1) || (tail == N))
                {
                    tail = 0;
                }

                items[tail] = value;
                Console.WriteLine("Item added successfully!");
                tail = tail + 1;
                if (head == -1)
                {
                    head = 0;
                }
                if ((head == N) && (tail == N))
                {
                    head = tail = 0;
                }
            }
        }

        public T Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty!");
                return default(T);
            }
            else
            {
                T value = items[head];
                items[head] = default(T);
                head = head + 1;
                if (head == tail)
                {
                    head = tail = -1;
                }
                if (tail == N)
                {
                    tail = -1;
                }

                return value;
            }
        }

        public override bool IsEmpty()
        {
            return head == -1;
        }

        public override bool IsFull()
        {
            if ((head == -1) && (tail == -1))
            {
                return false;
            }
            return ((head == 0 && tail == N) || (tail == head));
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
                return items[head];
            }
        }
    }
}
