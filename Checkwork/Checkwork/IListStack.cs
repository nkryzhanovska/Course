﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkwork
{
    public interface IListStack<T>
    {
        void Push(T value);
        T Pop();
    }
   
}
