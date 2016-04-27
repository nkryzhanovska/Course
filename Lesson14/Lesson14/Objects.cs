using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14
{
    public class Objects
    {
        public List<string> arrayStack;
        public List<string> arrayQueue;

        private void CreateArray()
        {
            char[] letters="qwerrtyuiopasdfghjklzxcvbnm".ToCharArray();
            Random rand = new Random();
            string value = "";
            foreach (string item1 in arrayStack)
            {
                for (int i = 0; i < 10; i++)
                {
                    value += letters[rand.Next(0, 25)].ToString();
                }
               arrayStack.Add(value);
            }
            foreach (string item2 in arrayQueue)
            {
                for (int i = 0; i < 10; i++)
                {
                    value += letters[rand.Next(0, 25)].ToString();
                }
                arrayQueue.Add(value);
            }
        }
    }
}
