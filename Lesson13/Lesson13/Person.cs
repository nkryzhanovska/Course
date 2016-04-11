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
            PersonGenerator NameGenerator = new PersonGenerator();
            Name = NameGenerator.Generator();
        }
    

    }
}
