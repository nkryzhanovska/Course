using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkwork
{
    public interface IMyLinkedList<T>:IPrintable
    {
        void AddNode(T value);
        T RemoveNode();
        bool IsEmpty();
        T Get();
    }
}
