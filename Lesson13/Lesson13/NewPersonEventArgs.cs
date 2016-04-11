using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson13
{
    public class NewPersonEventArgs : EventArgs
    {
        public string Person { set; get; }
    }
}
