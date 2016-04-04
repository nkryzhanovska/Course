using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkwork
{
    public class ListStack<T>: Buffer<T>, IListStack<T>
    {
      
        public ListStack()
        {
            list = new MyLinkedList<T>();
        }

        
        public override bool IsEmpty()
        {
            return false;
        }

        public override bool IsFull()
        {
            return false;
        }

        public override T Peek()
        {
            return list.Get();
        }
        
        public void Push(T value)
        {
            list.AddNode(value);
            
        }

        public T Pop()
        {
            return list.RemoveNode();
        }

        public override void Print()
        {
            list.Print();
        }

        
        
    }
    
}
