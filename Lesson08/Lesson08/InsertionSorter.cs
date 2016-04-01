using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeless8
{
    class InsertionSorter<T>:Sorter<T> where T:IComparable
    {
        public InsertionSorter(T[] array)
        {
            sortarray = array;
        }

        public override void Sort()
        {
            for (int i = 0; i < sortarray.Length - 1; i++)
            {
                int j = i + 1;
                while ((j > 0) && (sortarray[j - 1].CompareTo(sortarray[j])>0))
                {
                    Swap(j - 1, j);
                    j = j - 1;

                }
            }
        }
    }
}
