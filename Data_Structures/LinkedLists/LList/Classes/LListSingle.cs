﻿using System;
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

        //Methods
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
        /// Finds the middle of the list and returns a node reference
        /// </summary>
        /// <returns>Node reference</returns>
        public Node MiddleOfList()
        {
            Node Current = Head, Runner = Head;
            while(Runner.Next != null)
            {
                Runner = Runner.Next.Next;
                Current = Current.Next;
            }
            return Current;
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
        /// Removes the node with the specific value given. 
        /// </summary>
        /// <param name="value">Value to be removed</param>
        /// <returns>With a node if the value exists or null if not found</returns>
        public Node RemoveNode(object value)
        {
            if (Head.Value == value) return Remove();
            Node Current = Head, Walker = Head;
            while(Current != null)
            {
                Current = Current.Next;
                if(Current.Value == value)
                {
                    Node temp = Current;
                    Walker.Next = temp.Next;
                    temp.Next = null;
                    return temp;
                }
                Walker = Walker.Next;
            }
            return null;           
        }
        /// <summary>
        /// Finds if the specified value exists within the list
        /// </summary>
        /// <param name="value">Value to be found</param>
        /// <returns>true if exist, else false</returns>
        public bool Find(object value)
        {
            Node Current = Head;
            while(Current != null)
            {
                if(Current.Value == value) return true;
                Current = Current.Next;
            }
            return false;
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

        //TODOs:
        //AddBefore(Node newNode, Node node) adds newNode before the specific node
        //AddAfter(Node newNode, Node node) adds newNode after the specific node
    }
}