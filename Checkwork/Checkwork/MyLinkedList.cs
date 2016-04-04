using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkwork
{
    public class MyLinkedList<T> : Node<T>, IMyLinkedList<T>
    {
        private Node<T> Head = null;

        public void AddNode(T value)
        {
            Node<T> newNode = new Node<T>();
            newNode.NodeContent = value;
            newNode.Next = Head;
            Head = newNode;

            Console.WriteLine("Item pushed successfully!", Head.NodeContent);
        }

        public bool IsEmpty()
        {
            return (Head == null);
        }


        public void Print()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty!");                
            }
            else
            {
                Node<T> current = Head;
                while (current != null)
                {
                    Console.WriteLine("Stack Element {0}", current.NodeContent);
                    current = current.Next;
                }
            }
        }


        public T RemoveNode()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty!");
                return default(T);
            }
            else
            {
                Node<T> temp = Head;
                Head = Head.Next;
                return temp.NodeContent;
            }
        }

        public T Get()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Nothing is here!");
                return default(T);
            }
            else
            {
                return Head.NodeContent;
            }
        }
    }
}
