using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13
{
    public class Person : PersonGenerator
    {
        public string Name;
        public string Path;
        public int time;

        public void PersonEvent()
        {
            PersonGenerator NameGenerator = new PersonGenerator(time);
            NameGenerator.Path = Path;
            PersonSaver NameSaver = new PersonSaver();
            NameGenerator.NewPerson += NameSaver.SavePerson;
            Name = NameGenerator.Generator();            
        }


    }
}
