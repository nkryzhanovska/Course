using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13
{
    public interface IFilter
    {
        bool IsSatisfied(List<string> FilterList, string line);
        
    }
}
