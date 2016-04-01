using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson01
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            
            System.Console.WriteLine("If X is divided on Y");
            System.Console.WriteLine("Enter value X");
            x = Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine("Enter value Y");
            y = Convert.ToInt32(System.Console.ReadLine());

            if ((x % y) == 0)
            {
                System.Console.WriteLine("Result: Divided");
                System.Console.ReadLine();
            }
            else
            {
                System.Console.WriteLine("Result: Not divided");
                System.Console.ReadLine();
            }

        }
    }
}
