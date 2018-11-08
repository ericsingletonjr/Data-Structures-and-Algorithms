using System;
using System.Collections.Generic;
using System.Text;

namespace LList.Classes
{
    public class LListSingle
    {
        //Class Fields
        public Node Head { get; set; }

        //Available Constructors
        public LListSingle() { }

        public LListSingle(Node node)
        {
            Head = node;
        }
        /// <summary>
        /// Adds node directly to the front of the list
        /// O(1)
        /// </summary>
        /// <param name="node"></param>
        public void Add(Node node)
        {
            node.Next = Head;
            Head = node;
        }
        /// <summary>
        /// Removes the front node from the list
        /// O(1)
        /// </summary>
        /// <returns>Removed Node</returns>
        public Node Remove()
        {
            Node temp = Head;
            Head = temp.Next;
            temp.Next = null;
            return temp;
        }
        /// <summary>
        /// Prints the current list
        /// </summary>
        public void Print()
        {
            Node Current = Head;
            while (Current.Next != null)
            {
                Console.Write($"{Current.Value} -> ");
                Current = Current.Next;
            }
            Console.WriteLine($"{Current.Value} -> NULL");
        }
    }
}
