using System;
using System.Collections.Generic;
using System.Text;

namespace QueueWithStacks.Classes
{
    public class Stack
    {
        public Node Top { get; set; }

        public Stack(Node node)
        {
            Top = node;
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
        }
        /// <summary>
        /// Method that will remove the top node from the
        /// stack
        /// </summary>
        /// <returns>Popped node</returns>
        public Node Pop()
        {
            Node temp = Top;
            Top = temp.Next;
            temp.Next = null;
            return temp;
        }
        /// <summary>
        /// Method that looks at the top of the stack
        /// </summary>
        /// <returns>Top node or null if empty</returns>
        public Node Peek()
        {
            return Top;
        }
        /// <summary>
        /// Method that traverses and prints the stack order
        /// </summary>
        public void Print()
        {
             Node Current = Top;

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
