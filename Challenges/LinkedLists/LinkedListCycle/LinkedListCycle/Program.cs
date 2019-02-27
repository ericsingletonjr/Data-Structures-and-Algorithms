using System;
using System.Collections.Generic;
using LList.Classes;

namespace LinkedListCycle
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }

        /// <summary>
        /// This method, I wanted to try and use a try-catch to see how reliable
        /// it would be. It works and is clunky but another approach to solving
        /// this problem
        /// </summary>
        /// <param name="Head">Head node of the incoming list</param>
        /// <returns>True or false based on if cycle detected</returns>
        public static bool DetectListCycle(Node Head)
        {
            // First check if the incoming list is valid. If not
            // we can easily finish our operation
            if (Head == null || Head.Next == null) return false;

            // Next set our two ref nodes to head
            Node Walker = Head, Runner = Head;

            // For this, I chose to use the slower node as the way to
            // break out. BigO still remains O(n) as it needs to iterate
            // through the list
            while (Walker != null)
            {
                // This tries to assign Runner two nodes ahead each
                // iteration. If it comes across a null reference, that
                // means there is no chance of a cycle so it catches the
                // exception and returns false
                try
                {
                    Runner = Runner.Next.Next;
                }
                catch
                {
                    return false;
                }
                Walker = Walker.Next;
                
                // If both refs ever equal one another, then it will return
                // true. This doesn't happen in the event that they are both
                // null as the Runner ref will become null first and trigger
                // the try-catch
                if (Walker == Runner) return true;
            }

            // This return is to fulfill the requirements of 
            // needing a returned value for the method. The actual returns
            // all happend within the while loop with this logic
            return false;
        }
        /// <summary>
        /// This is a method refactored from a previous answer, taking
        /// advantage of the null-operator ?. as a way to check and
        /// assign null values.
        /// </summary>
        /// <param name="Head">Head node of the incoming linked list</param>
        /// <returns>True or false based on if a cycle exists or not</returns>
        public static bool DetectListCycleRefactored(Node Head)
        {
            // First check if the incoming list is valid. If not
            // we can easily finish our operation
            if (Head == null || Head.Next == null) return false;

            // If we pass the first check, we want to assign our two
            // ref nodes. We don't just set them Head as it would
            // invalidate our while loop immediately so we step them
            // forward
            Node Walker = Head.Next, Runner = Head.Next?.Next;

            // Here we iterate our list. This while loop is not infinite
            // because if there is a cycle, the two refs will sync up at
            // some point. If there is an end to the list (NULL) both will
            // become null thus equal each other
            while(Walker != Runner)
            {
                Walker = Walker?.Next;
                Runner = Runner?.Next?.Next;
            }

            // This ternary statement is a check whether the
            // node is null or not. If not, it returns true
            //     ( Condition  ) ? True : False  <- Ternary format
            return Walker != null ? true : false;            
        }
        /// <summary>
        /// For this version, we aren't return a bool but the specific
        /// node where the cycle begins. 
        /// </summary>
        /// <param name="Head">Head of the list</param>
        /// <returns>Either the specific node or null depending on cycle's existence</returns>
        public static Node DetectListCycleV2(Node Head)
        {
            // First check if the incoming list is valid. If not
            // we can easily finish our operation
            if (Head == null || Head.Next == null) return null;

            // We are approaching this from a HashTable mindset where
            // we store each node that we've visited in a list. We will
            // check if the list contains that current node, if not, add
            // and move on. If we do contain the node it means we have
            // a cycle and can return it since that will be the first instance
            // of our cycle
            List<Node> Visited = new List<Node>();

            // Ref node for iteration through the LinkedList
            Node Current = Head;

            // here we are iterating through our LinkedList,
            // checking if nodes exist in the list, adding them
            // if not or returning the node if it does
            while (Current != null)
            {
                if (Visited.Contains(Current))
                {
                    return Current;
                }
                Visited.Add(Current);
                Current = Current.Next;
            }

            // If our ref reaches the end of the list then
            // that indicates there is no cycle thus we return
            // a null value back
            return null;
        }
        /// <summary>
        /// This is a refactored version of the previous answer. While it has
        /// more lines to it, it is more space efficient with O(1)
        /// </summary>
        /// <param name="Head">Head node of the list</param>
        /// <returns>Either the cycle node or null</returns>
        public static Node DetectListCycleV2Refactored(Node Head)
        {
            // First check if the incoming list is valid. If not
            // we can easily finish our operation
            if (Head == null || Head.Next == null) return null;

            // If we pass the first check, we want to assign our two
            // ref nodes like the DetectListCycleRefactored method
            Node Walker = Head.Next, Runner = Head.Next?.Next;

            // Similar to DetectListCycleRefactored, we iterate until the
            // two ref nodes equal each other
            while(Walker != Runner)
            {
                Walker = Walker?.Next;
                Runner = Runner?.Next?.Next;
            }

            // If this ref happens to be null, then we know a cycle
            // does not exist
            if (Walker == null) return null;

            // using Floyd's Cycle Detection Algorithm, we
            // set our runner ref to the head of the list and
            // will iterate a node at a time
            Runner = Head;

            // Same as our previous while loop but notice
            // each ref is only moving at one node each iteration.
            // Based on the algorithm, by the time these two points
            // meet, it will be the beginning of the cycle
            while (Walker != Runner)
            {
                Walker = Walker.Next;
                Runner = Runner.Next;
            }

            // Once we break out of the while loop we just have
            // to return a ref to indicate the start of the cycle
            return Walker;
        }
    }
}