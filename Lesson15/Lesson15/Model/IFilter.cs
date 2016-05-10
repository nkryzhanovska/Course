using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15
{
    public interface IFilter
    {
        string ConfigFile { set; get; }
        List<string> AddFilterinItems();
        void Init();
    }
}
