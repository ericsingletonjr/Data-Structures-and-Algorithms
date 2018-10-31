using System;
using System.Collections.Generic;
using FizzBuzzTree.Classes;

namespace FizzBuzzTree
{
    public class Program
    {
        static void Main(string[] args)
        {
            StringTree stringTree = new StringTree(new Node("3"));
            stringTree.Add(new Node("5"), stringTree.Root);
            stringTree.Add(new Node("2"), stringTree.Root);
            stringTree.Add(new Node("4"), stringTree.Root);
            stringTree.Add(new Node("10"), stringTree.Root);
            stringTree.Add(new Node("9"), stringTree.Root);
            stringTree.Add(new Node("22"), stringTree.Root);
            stringTree.Add(new Node("15"), stringTree.Root);
            stringTree.BreadthFirst(stringTree.Root);
            Console.WriteLine("-----");
            FizzBuzzTree(stringTree);
            stringTree.BreadthFirst(stringTree.Root);
        }
        /// <summary>
        /// Method utilizing the breadthFirst traversal approach. Takes in a tree and
        /// checks the value of each node and conducts if it is Fizz, Buzz or FizzBuzz
        /// </summary>
        /// <param name="stringTree">Input is a tree</param>
        /// <returns>The tree modified</returns>
        public static StringTree FizzBuzzTree(StringTree stringTree)
        {
            Node root = stringTree.Root;

            Queue<Node> breadth = new Queue<Node>();
            breadth.Enqueue(root);

            while (breadth.TryPeek(out root))
            {
                Node front = breadth.Dequeue();
                front.Value = FizzBuzz(front.Value);
                if (front.LeftChild != null)
                {
                    breadth.Enqueue(front.LeftChild);
                }
                if (front.RightChild != null)
                {
                    breadth.Enqueue(front.RightChild);
                }
            }
            return stringTree;
        }
        /// <summary>
        /// Method to conduct FizzBuzz Check
        /// </summary>
        /// <param name="value">String value in node</param>
        /// <returns>Fizz, Buzz, FizzBuzz or same value if no match</returns>
        public static string FizzBuzz(string value)
        {
            try
            {
                int check = Int32.Parse(value);
                if (check % 3 == 0 && check % 5 == 0) return "FizzBuzz";
                if (check % 3 == 0) return "Fizz";
                if (check % 5 == 0) return "Buzz";
            } catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return value;
        }
    }
}
