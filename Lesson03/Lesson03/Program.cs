using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 0;
            int i = 0;
            System.Console.WriteLine("Enter the number of elements in array:");
            length = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[length];
            System.Console.WriteLine("Enter the value of each element in array:");
            for (i = 0; i < length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            System.Console.WriteLine("The Maximum and Minimum value in the array that you entered are:");
            Console.WriteLine("Maximum value is:  " + Max(array, length));
            Console.WriteLine("Minimum value is:  " + Min(array, length));
            Console.ReadLine();
        }

        static int Max(int[] array1, int length)
        {
            int max = 0;
            for (int i = 0; i < length; i++)
            {
                if (max < array1[i])
                {
                    max = array1[i];
                }
            }
            return max;
        }

        static int Min(int[] array2, int length)
        {
            int min = 0;
            for (int i = 0; i < length; i++)
            {
                if (min > array2[i])
                {
                    min = array2[i];
                }
            }
            return min;
        }

    }
}
