using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13
{
    public class ReadFile:IReadFile
    {
        public List<string> Read(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                List<string> outList = new List<string>();
                while ((line = reader.ReadLine()) != null)
                {
                    outList.Add(line);
                }
                return outList;
            }
        }
    }
}
