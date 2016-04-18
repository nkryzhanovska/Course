using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13
{
    public class PersonSaver
    {   
        
        WriteFile write = new WriteFile();
        private string tempFile;

        public PersonSaver(string tempOutput)
        {
            tempFile = tempOutput;
        }

        public PersonSaver()
        {
            int Count;
        }

        public void SavePerson(object sender, NewPersonEventArgs args)
        {
            string result = args.Person;
            if (result != null)
            {
                write.Write(result, tempFile);
                Console.WriteLine("New person is added - {0}", result);
            }

        }
    }
}
