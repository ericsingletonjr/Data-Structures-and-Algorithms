using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue.Classes
{
    class Stack
    {
        public Node Top { get; set; }
        public Node Current { get; set; }

        public Stack(Node node)
        {
            Top = node;
            Current = node;
        }

        public void Push(Node node)
        {
            node.Next = Top;
            Top = node;
            Current = node;
        }

        public Node Pop()
        {
            Current = Top.Next;
            Top = Current;
            return Top ?? null;
        }

        public Node Peek()
        {
            return Top ?? null;
        }

        public void Print()
        {
            Current = Top;

            while(Current.Next != null)
            {
                Console.Write($"{Current.Value}-->");
                Current = Current.Next;
            }
            Console.Write($"{Current.Value}-->");
            Console.WriteLine("");
        }

    }
}
