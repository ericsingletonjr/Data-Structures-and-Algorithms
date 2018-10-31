using System;
using System.Collections.Generic;
using TreeIntersection.Classes;

namespace TreeIntersection
{
    public class Program
    {
        static void Main(string[] args)
        {
            BinaryTree bt1 = new BinaryTree(new Node(10));
            BinaryTree bt2 = new BinaryTree(new Node(50));

            bt1.Add(new Node(8), bt1.Root);
            bt1.Add(new Node(100), bt1.Root);
            bt1.Add(new Node(200), bt1.Root);
            bt1.Add(new Node(75), bt1.Root);
            bt1.Add(new Node(20), bt1.Root);
            bt1.Add(new Node(150), bt1.Root);

            bt2.Add(new Node(64), bt2.Root);
            bt2.Add(new Node(20), bt2.Root);
            bt2.Add(new Node(100), bt2.Root);
            bt2.Add(new Node(80), bt2.Root);
            bt2.Add(new Node(200), bt2.Root);
            bt2.Add(new Node(75), bt2.Root);

            //Same values are 20, 100, 200, 75
            foreach (int value in TreeIntersect(bt1, bt2))
            {
                Console.WriteLine(value);
            }
        }
        /// <summary>
        /// Method takes in two Binary trees and traverses one adding all of its
        /// values to a hash set, then proceeds to traverse the second tree and compare 
        /// if the values in the second tree contain the same values. If it does,
        /// add it to a list that is then returned at the end of the second tree traversal.
        /// </summary>
        /// <param name="bt1">Binary Tree</param>
        /// <param name="bt2">Binary Tree</param>
        /// <returns>returns a list of repeated values</returns>
        public static List<int> TreeIntersect(BinaryTree bt1, BinaryTree bt2)
        {
            HashSet hs = new HashSet();
            List<int> values = new List<int>();
            Queue<Node> q = new Queue<Node>();

            hs = FirstTraversal(bt1, hs);

            Node root = bt2.Root;
            q.Enqueue(root);

            while(q.TryPeek(out root))
            {
                Node front = q.Dequeue();
                try
                {
                    hs.Add(front.Value.ToString(), front.Value);
                }
                catch
                {
                    values.Add(front.Value);
                }
                if (front.LeftChild != null)
                {
                    q.Enqueue(front.LeftChild);
                }
                if (front.RightChild != null)
                {
                    q.Enqueue(front.RightChild);
                }
            }
            return values;
        }
        /// <summary>
        /// Helper Method to set up hash set and reduce the complexity of
        /// main method
        /// </summary>
        /// <param name="tree">Binary tree</param>
        /// <param name="set">HashSet</param>
        /// <returns>A HashSet filled with the values of the given tree</returns>
        public static HashSet FirstTraversal(BinaryTree tree, HashSet set)
        {
            Node root = tree.Root;
            Queue<Node> q = new Queue<Node>();
            q.Enqueue(root);
            while (q.TryPeek(out root))
            {
                Node front = q.Dequeue();
                set.Add(front.Value.ToString(), front.Value);
                if (front.LeftChild != null)
                {
                    q.Enqueue(front.LeftChild);
                }
                if (front.RightChild != null)
                {
                    q.Enqueue(front.RightChild);
                }
            }
            return set;
        }
    }
}
