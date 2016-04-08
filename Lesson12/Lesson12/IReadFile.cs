using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12
{
    public interface IReadFile
    {
        List<string> Read(string path);
    }
}
