using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12
{
    public class WriteFile : IWriteFile
    {
        public void Write(string line, string tempOutput)
        {
            using (StreamWriter writer = new StreamWriter(tempOutput, true))
            {
                
                    writer.WriteLine(line);

            }
        }
    }
}
