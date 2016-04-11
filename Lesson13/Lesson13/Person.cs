using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13
{
    public class Person : PersonGenerator
    {
        string Name;

        public Person()
        {
            //PersonGenerator NameGenerator = new PersonGenerator();
            //Name = NameGenerator.Generator();

            Console.WriteLine("Please specify Timer interval:");
            int time = Int32.Parse(Console.ReadLine());

            PersonGenerator NameGenerator = new PersonGenerator(time);
            PersonSaver NameSaver = new PersonSaver();
            NameGenerator.NewPerson += NameSaver.SavePerson;
            string newPerson = personGen.Generator();
        }


    }
}
