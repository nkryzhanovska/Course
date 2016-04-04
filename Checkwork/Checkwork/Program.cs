using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkwork
{
    class Program
    {
        static void Main(string[] args)
        {
            ListStack<object> stack = new ListStack<object>();
            
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Stack Menu based on List ");
                Console.WriteLine("1. Add an element");
                Console.WriteLine("2. Remove element ");
                Console.WriteLine("3. Display top element ");
                Console.WriteLine("4. Display all elements");
                Console.WriteLine("5. Exit");
                Console.Write("Select your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter an Element: ");
                        stack.Push(Console.ReadLine());
                        break;

                    case 2: Console.WriteLine("Element removed from stack: {0}", stack.Pop());
                        break;

                    case 3:
                        Console.WriteLine("Top element is of stack: {0}", stack.Peek());
                        break;

                    case 4:
                        Console.WriteLine("Stack List:");
                        stack.Print();
                        break;

                    case 5: System.Environment.Exit(1);
                        break;
                }
                Console.ReadKey();
            }
        }
    
    }
}
