using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12
{
    public interface IWorkFiles
    {
        List<string> ReadFile(string path);
        void WriteList(HashSet<string> tempList, string tempOutput);
    }
}
