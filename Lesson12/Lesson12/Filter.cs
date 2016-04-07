using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12
{
    public class Filter : WorkFiles, IFilter
    {


        HashSet<string> uniqueFilterList;

        public Filter()
        {
            uniqueFilterList = new HashSet<string>();
        }


        public void ApplyFilter(string InputFile, string FilterFile, string OutputFile, int type)
        {
            List<string> InputList = ReadFile(InputFile);
            List<string> outFilter = ReadFile(FilterFile);

            switch (type)
            {
                case 1:
                    FilterBlack(InputList, outFilter);
                    WriteList(uniqueFilterList, OutputFile);
                    break;

                case 2: FilterkWhite(InputList, outFilter);
                    WriteList(uniqueFilterList, OutputFile);
                    break;

            }
        }

        public void ApplyFilter1(string InputFile, string FilterFile, string FilterFile1, string OutputFile, int type)
        {
            List<string> InputList = ReadFile(InputFile);
            List<string> outFilter = ReadFile(FilterFile);
            List<string> outFilter1 = ReadFile(FilterFile1);

            switch (type)
            {
                case 3:
                    FilterBlackWhite(InputList, outFilter, outFilter1);
                    WriteList(uniqueFilterList, OutputFile);

                    break;

            }


        }
        public void FilterBlack(List<string> InputList, List<string> outFilter)
        {
            for (int i = 0; i < InputList.Count; i++)
            {
                string temp = InputList[i];
                {
                    if (!outFilter.Contains(temp))
                    {
                        uniqueFilterList.Add(temp);
                    }

                }
            }
        }

        public void FilterkWhite(List<string> InputList, List<string> outFilter)
        {
            for (int i = 0; i < InputList.Count; i++)
            {
                string temp = InputList[i];
                if (outFilter.Contains(temp))
                {
                    uniqueFilterList.Add(temp);
                }

            }
        }

        public void FilterBlackWhite(List<string> InputList, List<string> outFilter, List<string> outFilter1)
        {
            for (int i = 0; i < InputList.Count; i++)
            {
                string temp = InputList[i];
                {
                    if (!outFilter.Contains(temp))
                    {
                        if (outFilter1.Contains(temp))
                        {
                            uniqueFilterList.Add(temp);
                        }
                    }

                }
            }
        }
    }
}
