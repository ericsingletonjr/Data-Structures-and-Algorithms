using System;
using System.Collections.Generic;
using System.Text;

namespace PriorityQueue.Classes
{
    public class PriorityQ
    {
        public Node Front { get; set; }
        public Node Back { get; set; }
        public int HighestPriority { get; set; }

        public PriorityQ() { }
        
        /// <summary>
        /// This method is to check if the queue is empty or not
        /// </summary>
        /// <returns>Bool based on if it is true or false</returns>
        public bool IsEmpty()
        {
            if (Front == null || Back == null) return true;
            return false;
        }
        /// <summary>
        /// This method is used to enqueue a new node to the queue.
        /// </summary>
        /// <param name="newNode">Node to be added</param>
        public void Enqueue(Node newNode)
        {
            if (newNode.Priority > HighestPriority) HighestPriority = newNode.Priority;
            if (Front == null)
            {
                Front = newNode;
                Back = newNode;
                return;
            }

            Back.Next = newNode;
            Back = newNode;
        }
        /// <summary>
        /// This method is to Dequeue a node from the queue. The difference
        /// with this dequeue from normal versions is that it will dequeue
        /// the highest priority node and then do another check to see if it
        /// needs to reset the priority of the queue
        /// </summary>
        /// <returns>removed node</returns>
        public Node Dequeue()
        {
            if (Front == null || Back == null) return null;

            Node temp = null, prev = null;
            Node current = Front;

            if(Front.Priority == HighestPriority)
            {
                temp = Front;
                Front = Front.Next;
                temp.Next = null;

                return PriorityCheckHelper(temp, Front);
            }
             
            while(current != null)
            {
                if(current.Priority == HighestPriority)
                {
                    temp = current;
                    prev.Next = current.Next;
                    temp.Next = null;
                    current = Front;

                    return PriorityCheckHelper(temp, current);
                }
                prev = current;
                current = current.Next;
            }
            return null;
        }
        /// <summary>
        /// Method used to print the priority queue
        /// </summary>
        public void Print()
        {
            Node Current = Front;
            while(Current.Next != null)
            {
                Console.Write($"(Current: {Current.Value} | Priority: {Current.Priority}) ->");
                Current = Current.Next;
            }
            Console.WriteLine($"(Current: {Current.Value} | Priority: {Current.Priority}) -> NULL");
        }

        // ------ HELPER METHODS ------ \\
        /// <summary>
        /// This helper method is to check if the priority needs to be reset
        /// </summary>
        /// <param name="held">This is the node that was removed. We pass it to help refact some code</param>
        /// <param name="cur">This is our node we use for iteration</param>
        /// <returns>the removed node</returns>
        private Node PriorityCheckHelper(Node held, Node cur)
        {
            int priorityCheck = 0;
 
            while (cur != null)
            {
                if (cur.Priority == HighestPriority) return held;
                if (cur.Priority > priorityCheck && cur.Priority != HighestPriority)
                {
                    priorityCheck = cur.Priority;
                }
                cur = cur.Next;
            }
            HighestPriority = priorityCheck;
            return held;
        }
    }
}
