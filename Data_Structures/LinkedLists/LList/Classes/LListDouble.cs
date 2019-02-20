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
            if (Head == null)
            {
                Head = node;
                return;
            }
            if (Head.Next == null)
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
            if (Head == null)
            {
                Head = node;
                return this;
            }
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
        /// Method to adding a node after a specified node
        /// </summary>
        /// <param name="newNode">Node to be added</param>
        /// <param name="node">Specified Node</param>
        /// <returns>Bool based on is successful or not</returns>
        public bool AddNodeAfter(Node newNode, Node node)
        {
            if(node == Head)
            {
                newNode.Next = Head.Next;
                if (Head.Next != null)
                {
                    Head.Next.Previous = newNode;
                }
                newNode.Previous = Head;
                Head.Next = newNode;
                return true;
            }

            Node Current = Head;
            while(Current.Next != null)
            {
                if(Current == node)
                {
                    newNode.Next = Current.Next;
                    Current.Next.Previous = newNode;
                    newNode.Previous = Current;
                    Current.Next = newNode;
                    return true;
                }
                Current = Current.Next;
            }
            if(Current == node)
            {
                Current.Next = newNode;
                newNode.Previous = Current;
                return true;
            }
            return false;
        }
        /// <summary>
        /// Method used to find the middle of the list
        /// </summary>
        /// <returns>Node found at the middle</returns>
        public Node MiddleOfList()
        {
            Node current = Head, runner = Head;
            while (runner.Next != null)
            {
                runner = runner.Next.Next;
                current = current.Next;
            }
            return current;
        }
        /// <summary>
        /// Method that removes the node from the front of the list
        /// </summary>
        /// <returns>Removed node</returns>
        public Node RemoveHead()
        {
            Node temp = Head;
            Head = temp.Next;
            Head.Previous = null;
            temp.Next = null;
            return temp;
        }
        /// <summary>
        /// Method that removes the node from the end of the list
        /// </summary>
        /// <returns>Removed node</returns>
        public Node RemoveTail()
        {
            Node temp = Tail;
            Tail = temp.Previous;
            Tail.Next = null;
            temp.Previous = null;
            return temp;
        }
        /// <summary>
        /// Method that removes node based on the specified value
        /// </summary>
        /// <param name="value">Value to find</param>
        /// <returns>Either a node on success or a null if not exist</returns>
        public Node RemoveNode(object value)
        {
            if(Head.Value.Equals(value)) return RemoveHead();
            if (Tail.Value.Equals(value)) return RemoveTail();

            Node current = Head;
            while(current.Next != null )
            {
                if(current.Value.Equals(value))
                {
                    Node temp = current;
                    current.Previous.Next = temp.Next;
                    current.Next.Previous = temp.Previous;
                    temp.Next = null;
                    temp.Previous = null;
                    return temp;
                }
                current = current.Next;
            }
            return null;
        }
        /// <summary>
        /// Method to Find if a specific node exists based off of its
        /// value
        /// </summary>
        /// <param name="value">value to search for</param>
        /// <returns>Bool based on if exist or not</returns>
        public bool Find(object value)
        {
            if (Tail.Value.Equals(value)) return true;

            Node current = Head;
            while(current.Next != null)
            {
                if (current.Value.Equals(value)) return true;
                current = current.Next;
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
