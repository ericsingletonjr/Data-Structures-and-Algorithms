using System;
using System.Collections.Generic;
using System.Text;

namespace Trees.Classes
{
    public class BinarySearchTree : BinaryTree
    {

        public BinarySearchTree(Node node) : base(node)
        {
            Root = node;
        }
        /// <summary>
        /// Method that is derrived from the BinaryTree class and is overriden
        /// to fit a Binary Search pattern.
        /// </summary>
        /// <param name="node"></param>
        /// <param name="reference"></param>
        public override void Add(Node node, Node reference)
        {
            Queue<Node> breadth = new Queue<Node>();
            breadth.Enqueue(reference);

            while (breadth.TryPeek(out reference))
            {
                Node front = breadth.Dequeue();
               
                if (front.LeftChild == null && node.Value < front.Value)
                {
                    front.LeftChild = node;
                    return;
                }
                else if (front.RightChild == null && node.Value > front.Value)
                {
                    front.RightChild = node;
                    return;
                }
                if (front.LeftChild != null && node.Value < front.Value)
                {
                    breadth.Enqueue(front.LeftChild);
                }
                if (front.RightChild != null && node.Value > front.Value)
                {
                    breadth.Enqueue(front.RightChild);
                }
            }
        }
        /// <summary>
        /// Method that is overriden to be refactored to follow a binary
        /// search pattern of search. This version of search is a Big(O)
        /// O(log^n) since each direction cuts the traversal of the tree in a
        /// logarithmic fashion
        /// </summary>
        /// <param name="root">Root node</param>
        /// <param name="value">desired value to be found</param>
        /// <returns>Node or a null</returns>
        public override Node Search(Node root, int value)
        {
            Queue<Node> breadth = new Queue<Node>();
            breadth.Enqueue(root);

            while (breadth.TryPeek(out root))
            {
                Node front = breadth.Dequeue();

                if (front.Value == value) return front;

                if (front.LeftChild != null && value < front.Value)
                {
                    breadth.Enqueue(front.LeftChild);
                }
                if (front.RightChild != null && value > front.Value)
                {
                    breadth.Enqueue(front.RightChild);
                }
            }
            return null;
        }
    }
}
