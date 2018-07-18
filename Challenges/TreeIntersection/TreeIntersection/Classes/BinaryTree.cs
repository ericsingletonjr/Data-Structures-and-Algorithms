using System;
using System.Collections.Generic;
using System.Text;

namespace TreeIntersection.Classes
{
    public class BinaryTree
    {
        public Node Root { get; set; }

        public BinaryTree(Node node)
        {
            Root = node;
        }

        /// <summary>
        /// Method that traverse the Tree starting from the Root, and iterating in a
        /// Root, Left, Right pattern. It uses the Depth First approach
        /// </summary>
        /// <param name="node">Starting node, usually the root</param>
        public void PreOrder(Node node)
        {
            Console.WriteLine(node.Value);

            if (node.LeftChild != null)
            {
                PreOrder(node.LeftChild);
            }

            if (node.RightChild != null)
            {
                PreOrder(node.RightChild);
            }
        }
        /// <summary>
        /// Method that traverses the Tree from the left most leaf, iterating
        /// until the right most leaf is reached. It uses the Depth First approach
        /// and is Left, Root, Right in its pattern
        /// </summary>
        /// <param name="node">Starting node, usually the root</param>
        public void InOrder(Node node)
        {
            if (node.LeftChild != null)
            {
                InOrder(node.LeftChild);
            }

            Console.WriteLine(node.Value);

            if (node.RightChild != null)
            {
                InOrder(node.RightChild);
            }
        }
        /// <summary>
        /// Method that traverses the tree start at the left most leaf and following 
        /// a Left, Right, Root pattern. It uses the Depth First approach.
        /// </summary>
        /// <param name="node">Starting node, usually the root</param>
        public void PostOrder(Node node)
        {
            if (node.LeftChild != null)
            {
                PostOrder(node.LeftChild);
            }

            if (node.RightChild != null)
            {
                PostOrder(node.RightChild);
            }

            Console.WriteLine(node.Value);
        }
        /// <summary>
        /// Method searches the tree using the breadth approach. Each
        /// node is enqueued and then recursively traversed until the 
        /// leafs are reached
        /// </summary>
        /// <param name="root">Root node</param>
        public void BreadthFirst(Node root)
        {
            Queue<Node> breadth = new Queue<Node>();           
            breadth.Enqueue(root);

            while (breadth.TryPeek(out root))
            {
                Node front = breadth.Dequeue();
                Console.WriteLine(front.Value);
                if (front.LeftChild != null)
                {
                    breadth.Enqueue(front.LeftChild);
                }
                if (front.RightChild != null)
                {
                    breadth.Enqueue(front.RightChild);
                }
            }
        }
        /// <summary>
        /// Method that traverses the tree starting at the root with a breadth
        /// approach to find the desired value. Big(O) is O(n)
        /// </summary>
        /// <param name="root">Root node of tree</param>
        /// <param name="value">Desired value</param>
        /// <returns>Node or null</returns>
        public virtual Node Search(Node root, int value)
        {
            Queue<Node> breadth = new Queue<Node>();
            breadth.Enqueue(root);

            while(breadth.TryPeek(out root))
            {
                Node front = breadth.Dequeue();

                if (front.Value == value) return front;

                if (front.LeftChild != null)
                {
                    breadth.Enqueue(front.LeftChild);
                }
                if (front.RightChild != null)
                {
                    breadth.Enqueue(front.RightChild);
                }
            }
            return null;
        }
        /// <summary>
        /// Method that adds a node based on a reference that is given by the 
        /// user
        /// </summary>
        /// <param name = "node" > New node to be added</param>
        /// <param name = "reference" > Reference node for desired start</param>
        public virtual void Add(Node node, Node root)
        {
            Queue<Node> breadth = new Queue<Node>();
            breadth.Enqueue(root);

            while (breadth.TryPeek(out root))
            {
                Node front = breadth.Dequeue();
                if (front.LeftChild != null)
                {
                    breadth.Enqueue(front.LeftChild);
                }
                if (front.RightChild != null)
                {
                    breadth.Enqueue(front.RightChild);
                }
                if (front.LeftChild == null)
                {
                    front.LeftChild = node;
                    return;
                }
                else if (front.RightChild == null)
                {
                    front.RightChild = node;
                    return;
                }
            }
        }
    }
}
