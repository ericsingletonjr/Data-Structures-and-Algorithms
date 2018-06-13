using System;
using System.Collections.Generic;
using System.Text;

namespace KthElement.Classes
{
    public class LinkList
    {
        /// <summary>
        /// This sets the member values to expect a 
        /// value of type Node.
        /// </summary>
        public Node Head { set; get; }
        public Node Current { set; get; }
        /// <summary>
        /// This is to set up the node. 
        /// </summary>
        /// <param name="node">The node we wish to add</param>
        public LinkList(Node node)
        {
            Head = node; 
            Current = node;
        }
        /// <summary>
        /// Method adds a node to the front of the list.
        /// Since the time does not change regardless of size
        /// This is O(1) - Time
        /// </summary>
        /// <param name="node">The node being added</param>        
        public void Add(Node node)
        {
            node.Next = Head; 
            Head = node;      
            Current = node;   
        }
        /// <summary>
        /// Method finds the node with the inputted value. 
        /// This has to traverse the entire list.
        /// This is O(n) - Time
        /// User must deal with error handling
        /// </summary>
        /// <param name="value">The int value to search</param>
        /// <returns>Node if found, otherwise null</returns>
        public Node Find(int value)
        {
            Current = Head;
            while(Current.Next != null)
            {
                if(Current.Value == value) return Current;
                Current = Current.Next;
            }
            return Current.Value == value ? Current : null;
        }
        /// <summary>
        /// Method traverses through the list and prints each node
        /// This is O(n) - Time
        /// </summary>
        public void Print()
        {
            Current = Head;
            while(Current.Next != null)
            {
                Console.Write($"{ Current.Value}-->");
                Current = Current.Next;
            }
            Console.WriteLine($"{ Current.Value}-->NULL");
        }
        /// <summary>
        /// Method inserts a new node before the selected node
        /// This is O(n) - Time
        /// </summary>
        /// <param name="newNode">New node to be added</param>
        /// <param name="node">Existing node to be compared</param>
        /// <returns>Current Node</returns>
        public Node AddBefore(Node newNode, Node node)
        {
            Current = Head;
            if (Head.Value == node.Value)
            {
                Add(newNode);
                return Current;
            }
            while(Current.Next != null)
            {
                if (Current.Next.Value == node.Value)
                {
                    newNode.Next = node;
                    Current.Next = newNode;
                    return Current;
                }
                Current = Current.Next;
            }
            return Current;
        }
        /// <summary>
        /// Method to insert a new node after the selected node
        /// </summary>
        /// <param name="newNode">New node to be added</param>
        /// <param name="node">Existing Node</param>
        /// <returns>Current Node</returns>
        public Node AddAfter(Node newNode, Node node)
        {
            Current = Head;
            while (Current.Next != null)
            {
                if(Current.Next.Value == node.Value)
                {
                    newNode.Next = node.Next;
                    node.Next = newNode;
                    return Current;
                }
                Current = Current.Next;
            }
            if (Current.Next == null) Current.Next = newNode;
            return Current;
        }       
        /// <summary>
        /// Method to add a node at the very end of the
        /// list. This is O(n) - Time
        /// </summary>
        /// <param name="newNode">New node to be added</param>
        /// <returns>Current Node</returns>
        public Node AddLast(Node newNode)
        {
            Current = Head;
            while(Current.Next != null)
            {
                Current = Current.Next;
            }
            Current.Next = newNode;          
            return Current;
        }
        /// <summary>
        /// Method that takes the give value and returns the node that is
        /// the value from the end of the linked list
        /// </summary>
        /// <param name="k">Position of the node you wish to return</param>
        /// <returns>Node at value k or null if it doesn't exist</returns>
        public Node KthElement(int k)
        {
            Current = Head;
            Node checker = Head;
            int counter = 0;

            while (checker.Next != null)
            {
                counter++;
                checker = checker.Next;
                if (counter > k) Current = Current.Next;
            }
            if (k > counter) return null;
            return Current;
        }
        
    }
}
