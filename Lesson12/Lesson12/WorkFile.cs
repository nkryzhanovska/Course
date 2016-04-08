using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12
{
    public class WorkFiles:IWorkFiles
    {
        public List<string> ReadFile(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                List<string> outList= new List<string>();
                while ((line = reader.ReadLine()) != null)
                {
                    outList.Add(line);
                }
                return outList;
            }
        }

        public void WriteFile(HashSet<string> tempList, string tempOutput)
        {
            using (StreamWriter writer = new StreamWriter(tempOutput))
            {
                foreach (string a in tempList)
                {
                    writer.WriteLine(a);

                }
            }
        }
    }
}
