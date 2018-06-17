using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue.Classes
{
    public class Stack
    {
        public Node Top { get; set; }
        public Node Current { get; set; }

        public Stack(Node node)
        {
            Top = node;
            Current = node;
        }
        /// <summary>
        /// Method that will add a new node to the top of
        /// the stack
        /// </summary>
        /// <param name="node"></param>
        public void Push(Node node)
        {
            node.Next = Top;
            Top = node;
            Current = node;
        }
        /// <summary>
        /// Method that will remove the top node from the
        /// stack
        /// </summary>
        /// <returns>New top node or null if empty</returns>
        public Node Pop()
        {
            Current = Top.Next;
            Top = Current;
            return Top ?? null;
        }
        /// <summary>
        /// Method that looks at the top of the stack
        /// </summary>
        /// <returns>Top node or null if empty</returns>
        public Node Peek()
        {
            return Top ?? null;
        }
        /// <summary>
        /// Method that traverses and prints the stack order
        /// </summary>
        public void Print()
        {
            Current = Top;

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
