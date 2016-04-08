using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12
{
    public interface IFilter
    {
        bool IsSatisfied();
        void Filter(string InputFile, string FilterFile, string OutputFile);
    }
}
