using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue.Classes
{
    class Queue
    {
        public Node Front { get; set; }
        public Node Current { get; set; }

        public Queue(Node node)
        {
            Front = node;
            Current = node;
        }

        public void Enqueue(Node node)
        {
            Current.Next = node;
            Current = node;
        }

        public Node Dequeue()
        {
            Current = Front.Next;
            Front = Current;
            return Front ?? null;
        }

        public Node Peek()
        {
            return Front ?? null;
        }

        public void Print()
        {
            Current = Front;
            while(Current.Next != null)
            {
                Console.Write($"{Current.Value}-->");
                Current = Current.Next;
            }
            Console.Write($"{Current.Value}-->NULL");
            Console.WriteLine("");
        }
    }
}
