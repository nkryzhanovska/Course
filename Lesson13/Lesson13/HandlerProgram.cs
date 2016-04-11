using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13
{
    public class HandlerProgram
    {
        public string WhiteFile = "Whitelist.txt";
        public string BlackFile = "Blacklist.txt";

        public string OutputBlackFile = "Output_blacklist.txt";
        public string OutputWhiteFile = "Output_whitelist.txt";
        public string OutputBlackWhiteFile = "Output_black_and_white.txt";

        List<IFilter> filter = new List<IFilter>();

        //read files
        ReadFile read = new ReadFile();
                
        //write files
        WriteFile write = new WriteFile();


        public void AddFilter()
        {
            filter.Add(new WhiteFilter());
            filter.Add(new BlackFilter());
        }


        public void FilterByBlack(string line)
        {
            List<string> BlackList = new List<string>();
            BlackList = read.Read(BlackFile);

            Console.WriteLine("Filtering by Black List ");

            if (filter[1].IsSatisfied(BlackList, line))
            {
                write.Write(line, OutputBlackFile);
            }

        }

        public void FilterByWhite(string line)
        {
            List<string> WhiteList = new List<string>();
            WhiteList = read.Read(WhiteFile);
            Console.WriteLine("Filtering by White List ");

            if (filter[0].IsSatisfied(WhiteList, line))
            {
                write.Write(line, OutputWhiteFile);
            }

        }

        public void FilterByBlackandWhite(string line)
        {
            Console.WriteLine("Filtering by Black and White Lists ");
            List<string> BlackList = new List<string>();
            BlackList = read.Read(BlackFile);
            List<string> WhiteList = new List<string>();
            WhiteList = read.Read(WhiteFile);
            

            if (filter[1].IsSatisfied(BlackList, line))
            {
                if (filter[0].IsSatisfied(WhiteList, line))
                {
                    write.Write(line, OutputBlackWhiteFile);
                }

            }

        }



    }
}
