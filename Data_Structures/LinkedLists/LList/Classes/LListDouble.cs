using System;
using System.Collections.Generic;
using System.Text;

namespace LList.Classes
{
    public class LListDouble
    {
        //Class Fields
        public Node Head { get; set; }
        public Node Tail { get; set; }

        //Available Contrsuctors
        public LListDouble() { }
        public LListDouble(Node node)
        {
            Head = node;
        }
        
        //Methods
        /// <summary>
        /// Method adds a node directly to the front of the list
        /// </summary>
        /// <param name="node">Node to be added</param>
        public void Add(Node node)
        {
            if(Head.Next == null)
            {
                Tail = Head;
                Tail.Previous = node;
            }
            node.Next = Head;
            Head.Previous = node;
            Head = node;
        }
        /// <summary>
        /// Method adds a node directly to the front of the list but is set
        /// up for chaining invocations
        /// </summary>
        /// <param name="node">Node to be added</param>
        /// <returns>List reference</returns>
        public LListDouble AddNode(Node node)
        {
            if (Head.Next == null)
            {
                Tail = Head;
                Tail.Previous = node;
            }
            node.Next = Head;
            Head.Previous = node;
            Head = node;
            return this;
        }
        /// <summary>
        /// Method to adding a node before a specified node
        /// </summary>
        /// <param name="newNode">Node to be added</param>
        /// <param name="node">Specified node</param>
        /// <returns>Bool based on is successful or not</returns>
        public bool AddNodeBefore(Node newNode, Node node)
        {
            if(node == Head)
            {
                Add(newNode);
                return true;
            }

            Node Current = Head;
            while (Current != null)
            {
                if(Current == node)
                {
                    newNode.Previous = Current.Previous;
                    Current.Previous.Next = newNode;
                    newNode.Next = Current;
                    Current.Previous = newNode;
                    return true;
                }
                Current = Current.Next;
            }
            return false;
        }
        /// <summary>
        /// Method used to print out the current list
        /// </summary>
        public void Print()
        {
            Node Current = Head;
            while (Current.Next != null)
            {
                Console.Write($"<- {Current.Value} ->");
                Current = Current.Next;
            }
            Console.WriteLine($"<- {Current.Value} -> NULL");
        }
    }
}
