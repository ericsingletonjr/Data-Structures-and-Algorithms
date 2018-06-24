using System;
using Trees.Classes;

namespace Trees
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree binaryTree = new BinaryTree(new Node(1));
            binaryTree.Add(new Node(2), binaryTree.Root);
            binaryTree.Add(new Node(3), binaryTree.Root);
            binaryTree.Add(new Node(4), binaryTree.Root);
            binaryTree.Add(new Node(5), binaryTree.Root);

            BinarySearchTree BST = new BinarySearchTree(new Node(50));
            BST.Add(new Node(25), BST.Root);
            BST.Add(new Node(10), BST.Root);
            BST.Add(new Node(75), BST.Root);
            BST.Add(new Node(60), BST.Root);
            BST.Add(new Node(72), BST.Root);
            BST.Add(new Node(80), BST.Root);

            //1-2-3-4-5
            binaryTree.BreadthFirst(binaryTree.Root);
            Console.WriteLine("------");
            //50-25-75-10-60-80-72
            BST.BreadthFirst(BST.Root);
            Console.ReadLine();
            Console.Clear();

            //1-2-4-5-3
            binaryTree.PreOrder(binaryTree.Root);
            Console.WriteLine("------");
            //50-25-10-75-60-72-80
            BST.PreOrder(BST.Root);
            Console.ReadLine();
            Console.Clear();

            //4-2-5-1-3
            binaryTree.InOrder(binaryTree.Root);
            Console.WriteLine("------");
            //10-25-50-60-72-75-80
            BST.InOrder(BST.Root);
            Console.ReadLine();
            Console.Clear();

            //4-5-2-3-1
            binaryTree.PostOrder(binaryTree.Root);
            Console.WriteLine("------");
            //10-25-72-60-80-75-50
            BST.PostOrder(BST.Root);
        }
    }
}
