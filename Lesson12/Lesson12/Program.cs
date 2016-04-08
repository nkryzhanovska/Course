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
            string WhiteList = "Whitelist.txt";
            string BlackList = "Blacklist.txt";
            string InputList = "Input.txt";

            string OutputBlacklist = "Output_blacklist.txt";
            string OutputWhitelist = "Output_whitelist.txt";
            string OutputBlackWhitelist = "Output_black_and_white.txt";
            string temp = "temp.txt";

            List<IFilter> filter = new List<IFilter>();
            filter.Add(new WhiteFilter());
            filter.Add(new BlackFilter());

            //List<IFilter> whitefilter = new WhiteFilter();
            //List<IFilter> blackfilter = new BlackFilter();
            IFilter blackfilter = new BlackFilter();
            IFilter whitefilter = new WhiteFilter();

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
                        blackfilter.Filter(InputList, BlackList, OutputBlacklist);
                        
                        break;

                    case 2:
                        Console.WriteLine("Filtering by White List ");
                        whitefilter.Filter(InputList, WhiteList, OutputWhitelist);
                        break;

                    case 3:
                        Console.WriteLine("Filtering by Black and White Lists ");

                        blackfilter.Filter(InputList, BlackList, temp);
                        whitefilter.Filter(temp, WhiteList, OutputBlackWhitelist);
                        break;

                    case 4: System.Environment.Exit(1);
                        break;
                }
                Console.ReadKey();
            }
        }

    }
}
