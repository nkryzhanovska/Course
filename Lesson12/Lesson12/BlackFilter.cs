using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12
{
    public class BlackFilter: WorkFiles, IFilter
    {
        HashSet<string> uniqueFilterList;

        public BlackFilter()
        {
            uniqueFilterList = new HashSet<string>();
        }


        public void Filter(string InputFile, string FilterFile, string OutputFile)
        {
            List<string> InputList = ReadFile(InputFile);
            List<string> outFilter = ReadFile(FilterFile);

            FilterBlack(InputList, outFilter);
            WriteFile(uniqueFilterList, OutputFile);
                   
             
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


        public bool IsSatisfied()
        {
            throw new NotImplementedException();
        }
    }
}
