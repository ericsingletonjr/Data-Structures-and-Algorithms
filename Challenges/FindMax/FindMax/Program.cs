using System;
using System.Collections.Generic;
using FindMax.Classes;

namespace FindMax
{
    public class Program
    {
        static void Main(string[] args)
        {
            BinaryTree binaryTree = new BinaryTree(new Node(5));
            binaryTree.Add(new Node(1), binaryTree.Root);
            binaryTree.Add(new Node(20), binaryTree.Root);
            binaryTree.Add(new Node(350), binaryTree.Root);
            binaryTree.Add(new Node(13), binaryTree.Root);
            binaryTree.Add(new Node(200), binaryTree.Root);
            binaryTree.Add(new Node(8), binaryTree.Root);
            binaryTree.Add(new Node(100), binaryTree.Root);

            int MaximumValue = FindMaximumValue(binaryTree);

            Console.WriteLine(MaximumValue);
        }
        /// <summary>
        /// Method that takes in a binary tree and through using the
        /// breadthfirst traversal, it will find the largest value and return the
        /// value.
        /// </summary>
        /// <param name="binaryTree">Expecting a Binary Tree</param>
        /// <returns>An int that is the largest value</returns>
        public static int FindMaximumValue(BinaryTree binaryTree)
        {
            int max = binaryTree.Root.Value;
            Node root = binaryTree.Root;

            Queue<Node> breadth = new Queue<Node>();
            breadth.Enqueue(root);

            while(breadth.TryPeek(out root))
            {
                Node front = breadth.Dequeue();
                max = front.Value > max ? front.Value : max;

                if(front.LeftChild != null)
                {
                    breadth.Enqueue(front.LeftChild);
                }
                if(front.RightChild != null)
                {
                    breadth.Enqueue(front.RightChild);
                }
            }
            return max;
        }
    }
}
