using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue.Classes
{
    public class Queue
    {
        public Node Front { get; set; }
        public Node Rear { get; set; }

        public Queue(Node node)
        {
            Front = node;
            Rear = node;
        }
        /// <summary>
        /// Method to add a node to the back of
        /// the queue
        /// </summary>
        /// <param name="node">New node to add</param>
        public void Enqueue(Node node)
        {
            Rear.Next = node;
            Rear = node;
        }
        /// <summary>
        /// Method to remove the node from the front of 
        /// the queue
        /// </summary>
        /// <returns>The dequeued node</returns>
        public Node Dequeue()
        {
            Node temp = Front;
            Front = temp.Next;
            temp.Next = null;

            return temp;
        }
        /// <summary>
        /// Method that looks at the front of the queue
        /// </summary>
        /// <returns>Front node or null</returns>
        public Node Peek()
        {
            return Front;
        }
        /// <summary>
        /// Method that traverses and prints out the queue order
        /// </summary>
        public void Print()
        {
            Node Current = Front;
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
