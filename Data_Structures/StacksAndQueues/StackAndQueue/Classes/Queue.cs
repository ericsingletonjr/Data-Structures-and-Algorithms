using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue.Classes
{
    public class Queue
    {
        public Node Front { get; set; }
        public Node Current { get; set; }

        public Queue(Node node)
        {
            Front = node;
            Current = node;
        }
        /// <summary>
        /// Method to add a node to the back of
        /// the queue
        /// </summary>
        /// <param name="node">New node to add</param>
        public void Enqueue(Node node)
        {
            Current.Next = node;
            Current = node;
        }
        /// <summary>
        /// Method to remove the node from the front of 
        /// the queue
        /// </summary>
        /// <returns>The new front node in the queue or null if none</returns>
        public Node Dequeue()
        {
            Current = Front.Next;
            Front = Current;
            return Front ?? null;
        }
        /// <summary>
        /// Method that looks at the front of the queue
        /// </summary>
        /// <returns>The front node in the queue or null if none</returns>
        public Node Peek()
        {
            return Front ?? null;
        }
        /// <summary>
        /// Method that traverses and prints out the queue order
        /// </summary>
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
