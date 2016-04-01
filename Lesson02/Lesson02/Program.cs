using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int value1 = 0;
            int value2 = 0;


            for (i = 1; i <= 100; i++)
            {
                value1 = i % 3;
                value2 = i % 5;
                if ((value1 == 0) && (value2 == 0))
                {
                    System.Console.WriteLine("FizzBuzz");
                }
                else if (value1 == 0)
                {
                    System.Console.WriteLine("Fizz");
                }
                else if (value2 == 0)
                {
                    System.Console.WriteLine("Buzz");
                }

                else
                {
                    System.Console.WriteLine(i);
                }
            }
            System.Console.ReadLine();
        }
    }
}