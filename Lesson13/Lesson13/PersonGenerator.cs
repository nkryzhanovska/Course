using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Lesson13
{
    public delegate void PersonGeneratorEventHandler(object sender, NewPersonEventArgs args);

    public class PersonGenerator:PersonSaver
    {
        public string Path;
        Timer timer = new Timer();
        public event PersonGeneratorEventHandler NewPerson;

        
        public PersonGenerator()
        {
            int Count;
        }

        public PersonGenerator(int value)
        {
            timer.Interval = value * 1000;
            timer.Elapsed += OnTimedEvent;
            timer.AutoReset = true;
            timer.Enabled = true;
            timer.Start();
        }

        public string Generator()
        {
            ReadFile read = new ReadFile();
            List<string> InputList = new List<string>();
            InputList = read.Read(Path);
            Random rand = new Random();
            int randomNumber = rand.Next(0, InputList.Count - 1);
            string line = InputList[randomNumber];
            return line;
        }

        

        private void OnTimedEvent(object sender, ElapsedEventArgs e)
        {
            Generator();
        }

        public void NewPersonCreated(string person)
        {

            if (NewPerson == null)
            {
                return;
            }

            NewPersonEventArgs args = new NewPersonEventArgs();
            args.Person = person;
            NewPerson(this, args);
        }
    }
}
