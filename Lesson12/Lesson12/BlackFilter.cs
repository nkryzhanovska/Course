using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12
{
    public class BlackFilter : IFilter
    {

        public bool IsSatisfied(List<string> FilterList, string line)
        {
            return (!FilterList.Contains(line));
        }
    }
}
