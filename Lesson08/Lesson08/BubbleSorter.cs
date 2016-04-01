using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeless8
{
    class BubbleSorter<T>:Sorter<T> where T:IComparable
    {
        public BubbleSorter(T[] array)
        {
            sortarray = array;
        }

        public override void Sort()
        {
            bool isChange = true;
            while (isChange)
            {
                isChange = false;
                for (int i = 0; i < sortarray.Length - 1; i++)
                {
                    if (sortarray[i].CompareTo(sortarray[i + 1])>0)
                    {
                        Swap(i, i + 1);
                        isChange = true;
                    }
                }
            }
        }
    }
}
