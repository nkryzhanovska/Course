using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeless8
{
    public abstract class Sorter<T> : ISorter<T> where T:IComparable
    {
        protected T[] sortarray;
        public abstract void Sort();

        public void Print()
        {
            for (int i = 0; i < sortarray.Length; i++)
            {
                Console.WriteLine("Person {0} = {1}", i + 1, sortarray[i]);
            }
        }

        protected void Swap(int a1, int a2)
        {
            T tmp = sortarray[a1];
            sortarray[a1] = sortarray[a2];
            sortarray[a2] = tmp;
        }
    }
}
