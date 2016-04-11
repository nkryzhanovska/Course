using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Lesson13
{
    public class PersonGenerator
    {
        private string Path;
        Timer timer = new Timer();

        public PersonGenerator(string path)
        {
            Path = path;
        }

        public PersonGenerator();

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

        public void GenerateTimer()
        {
            int _counter = 0;
            
            timer = new Timer();
            timer.Interval = 2000;
            timer.Elapsed += new EventHandler(TimerEventProcessor);
            label1.Text = _counter.ToString();
            timer.Start();

        }

        private void TimerEventProcessor(object sender, ElapsedEventArgs e)
            {
            label1.Text = _counter.ToString();
            _counter += 1;
            }
    }
}
