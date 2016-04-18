using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13
{
    class Program
    {
        static List<IFilter> filter = new List<IFilter>();
        static Person person = new Person();
        static int time;

        static void Main(string[] args)
        {

            
            string WhiteFile = "Whitelist.txt";
            string BlackFile = "Blacklist.txt";

            string OutputBlackFile = "Output_blacklist.txt";
            string OutputWhiteFile = "Output_whitelist.txt";
            string OutputBlackWhiteFile = "Output_black_and_white.txt";
            
            ReadFile read = new ReadFile();

            List<string> WhiteList = new List<string>();
            WhiteList = read.Read(WhiteFile);

            List<string> BlackList = new List<string>();
            BlackList = read.Read(BlackFile);

            AddFilter();

            WriteFile write = new WriteFile();

            SetTime();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Filtering persons:");
                Console.WriteLine("1. By Black List");
                Console.WriteLine("2. By White List ");
                Console.WriteLine("3. By Black and White Lists ");
                Console.WriteLine("4. Exit");
                Console.Write("Select your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                NewPerson();
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Filtering by Black List ");
                        if (filter[1].IsSatisfied(BlackList, person.Name))
                        {
                            write.Write(person.Name, OutputBlackFile);
                            Console.WriteLine("Person is added: {0}", person.Name);
                        }
                        else Console.WriteLine("Person is not added");

                        break;

                    case 2:
                        Console.WriteLine("Filtering by White List ");
                        if (filter[0].IsSatisfied(WhiteList, person.Name))
                        {
                            write.Write(person.Name, OutputWhiteFile);
                            Console.WriteLine("Person is added: {0}", person.Name);
                        }
                        else Console.WriteLine("Person is not added");
                        break;

                    case 3:
                        Console.WriteLine("Filtering by Black and White Lists ");
                        if (filter[1].IsSatisfied(BlackList, person.Name))
                        {
                            if (filter[0].IsSatisfied(WhiteList, person.Name))
                            {
                                write.Write(person.Name, OutputBlackWhiteFile);
                                Console.WriteLine("Person is added: {0}", person.Name);
                            }

                        }
                        else Console.WriteLine("Person is not added");
                        break;

                    case 4: System.Environment.Exit(1);
                        break;
                }
                Console.ReadKey();
            }
        }

        static void AddFilter()
        {
            filter.Add(new WhiteFilter());
            filter.Add(new BlackFilter());
        }

        static void NewPerson()
        {
            person.Path = "Input.txt";
            person.time = time;
            person.PersonEvent();
        }

        static void SetTime()
        {
            Console.WriteLine("Please specify Timer interval:");
            time = Convert.ToInt32(Console.ReadLine());
        }

    }
}
