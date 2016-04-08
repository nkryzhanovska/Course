using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12
{
    class Program
    {

        static void Main(string[] args)
        {
            string WhiteFile = "Whitelist.txt";
            string BlackFile = "Blacklist.txt";
            string InputFile = "Input.txt";

            string OutputBlackFile = "Output_blacklist.txt";
            string OutputWhiteFile = "Output_whitelist.txt";
            string OutputBlackWhiteFile = "Output_black_and_white.txt";
            
            
            //read files
            ReadFile read = new ReadFile();

            List<string> InputList = new List<string>();
            InputList = read.Read(InputFile);

            List<string> WhiteList = new List<string>();
            WhiteList = read.Read(WhiteFile);

            List<string> BlackList = new List<string>();
            BlackList = read.Read(BlackFile);

            //write files
            WriteFile write = new WriteFile();
            
            //create filters
            List<IFilter> filter = new List<IFilter>();
            filter.Add(new WhiteFilter());
            filter.Add(new BlackFilter());

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Filtering data from file by list");
                Console.WriteLine("1. By Black List");
                Console.WriteLine("2. By White List ");
                Console.WriteLine("3. By Black and White Lists ");
                Console.WriteLine("4. Exit");
                Console.Write("Select your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Filtering by Black List ");
                        foreach (string a in InputList)
                        {
                            if (filter[1].IsSatisfied(BlackList, a))
                            { 
                            write.Write(a, OutputBlackFile);
                            }
                        }
                        break;

                    case 2:
                        Console.WriteLine("Filtering by White List ");
                        foreach (string a in InputList)
                        {
                            if (filter[0].IsSatisfied(WhiteList, a))
                            {
                                write.Write(a, OutputWhiteFile);
                            }
                        }
                        break;

                    case 3:
                        Console.WriteLine("Filtering by Black and White Lists ");

                        foreach (string a in InputList)
                        {
                            if (filter[1].IsSatisfied(BlackList, a))
                            {
                                if (filter[0].IsSatisfied(WhiteList, a))
                                {
                                    write.Write(a, OutputBlackWhiteFile); 
                                }
                                
                            }
                        }
                        break;

                    case 4: System.Environment.Exit(1);
                        break;
                }
                Console.ReadKey();
            }
        }

    }
}
