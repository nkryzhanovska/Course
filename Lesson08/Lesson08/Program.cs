using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeless8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sorting or Buffer Arrays");
            Console.WriteLine("1. Sorting array");
            Console.WriteLine("2. Buffer array");
            Console.Write("Select your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Sorting();
                    break;

                case 2:
                    Buffering();
                    break;
            }
        }

        static void Sorting()
        {
            Random values = new Random();
            int n = 10;
            int[] ageB = new int[n];
            int[] ageI = new int[n];
            string[] nameB = new string[10] { "Tabby", "Olivia", "Noah", "Matthew", "Jack", "Troy", "Daniel", "Arabella", "Nash", "Clyde" };
            string[] nameI = new string[10] { "Matt", "Joanne", "Robert", "Mike", "Amy", "Mary", "Albert", "Samuel", "Emma", "Garry" };

            for (int i = 0; i < n; i++)
            {
                ageB[i] = values.Next(60);
                ageI[i] = values.Next(60);
                
            }

            BubbleSorter<int> array1 = new BubbleSorter<int>(ageB);
            InsertionSorter<int> array2 = new InsertionSorter<int>(ageI);
            BubbleSorter<string> array3 = new BubbleSorter<string>(nameB);
            InsertionSorter<string> array4 = new InsertionSorter<string>(nameI);

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Sorting using bubble or insertion method for people's ages and names");
                Console.WriteLine("1. Buble method for people ages");
                Console.WriteLine("2. Buble method for people names");
                Console.WriteLine("3. Insertion method people ages");
                Console.WriteLine("4. Insertion method people names");
                Console.WriteLine("5. Exit");
                Console.Write("Select your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Ages Buble Sort");
                        Console.WriteLine();
                        Console.WriteLine("Array before sorting:");
                        array1.Print();
                        Console.WriteLine();
                        array1.Sort();
                        Console.WriteLine("Array after sorting:");
                        array1.Print();
                        break;

                    case 2:
                        Console.WriteLine("Names Buble Sort");
                        Console.WriteLine();
                        Console.WriteLine("Array before sorting:");
                        array3.Print();
                        Console.WriteLine();
                        array3.Sort();
                        Console.WriteLine("Array after sorting:");
                        array3.Print();
                        break;

                    case 3:
                        Console.WriteLine("Ages Insersion Sort");
                        Console.WriteLine();
                        Console.WriteLine("Array before sorting:");
                        array2.Print();
                        array2.Sort();
                        Console.WriteLine();
                        Console.WriteLine("Array after sorting:");
                        array2.Print();
                        break;

                    case 4:
                        Console.WriteLine("Names Insersion Sort");
                        Console.WriteLine();
                        Console.WriteLine("Array before sorting:");
                        array4.Print();
                        array4.Sort();
                        Console.WriteLine();
                        Console.WriteLine("Array after sorting:");
                        array4.Print();
                        break;

                    case 5: System.Environment.Exit(1);
                        break;
                }
                Console.ReadKey();
            }
        }

        static void Buffering()
        {
            object[] arrayQ = new object[10];
            object[] arrayS = new object[10];
            MyQueue<object> array1 = new MyQueue<object>(arrayQ);
            MyStack<object> array2 = new MyStack<object>(arrayS);

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Queue  and Stack Menu (size -- 10)");
                Console.WriteLine("1. Add an element to queue");
                Console.WriteLine("2. Remove element from queue");
                Console.WriteLine("3. Add an element to stack");
                Console.WriteLine("4. Remove top element from the stack");
                Console.WriteLine("5. Display top element of stack");
                Console.WriteLine("6. Display elements of arrays");
                Console.WriteLine("7. Exit");
                Console.Write("Select your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Add an Element to queue: ");
                        array1.Enqueue(Console.ReadLine());
                        break;

                    case 2: Console.WriteLine("Element removed from queue: {0}", array1.Dequeue());
                        break;

                    case 3:
                        Console.WriteLine("Enter an Element to stack: ");
                        array2.Push(Console.ReadLine());
                        break;

                    case 4: Console.WriteLine("Element removed from stack: {0}", array2.Pop());
                        break;

                    case 5:
                        Console.WriteLine("Top element is of stack: {0}", array2.Peek());
                        break;

                    case 6:
                        Console.WriteLine("Queue array");
                        array1.Print();
                        Console.WriteLine();
                        Console.WriteLine("Stack array");
                        array2.Print();
                        break;

                    case 7: System.Environment.Exit(1);
                        break;
                }
                Console.ReadKey();
            }
        }

    }
}
