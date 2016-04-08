using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12
{
    public class WhiteFilter: WorkFiles, IFilter
    {
        HashSet<string> uniqueFilterList;

        public WhiteFilter()
        {
            uniqueFilterList = new HashSet<string>();
        }


        public void Filter(string InputFile, string FilterFile, string OutputFile)
        {
            List<string> InputList = ReadFile(InputFile);
            List<string> outFilter = ReadFile(FilterFile);

            FilterkWhite(InputList, outFilter);
            WriteFile(uniqueFilterList, OutputFile);
            
            
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


       public bool IsSatisfied()
       {
           throw new NotImplementedException();
       }
    }
}
