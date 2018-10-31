using System;
using Xunit;
using Trees.Classes;

namespace BinaryTreeTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(5, 5)]
        [InlineData(25, 25)]
        [InlineData(100, 100)]
        [InlineData(350, 350)]
        public void AddANodeToBinarySearchTree(int value, int expected)
        {
            BinarySearchTree BST = new BinarySearchTree(new Node(50));
            BST.Add(new Node(value), BST.Root);

            Assert.Equal(expected, BST.Search(BST.Root, value).Value);
        }
        [Theory]
        [InlineData(200, 200)]
        [InlineData(25, 25)]
        [InlineData(35, 35)]
        [InlineData(175, 175)]
        public void FindANodeInBinarySearchTree(int value, int expected)
        {
            BinarySearchTree BST = new BinarySearchTree(new Node(50));
            BST.Add(new Node(25), BST.Root);
            BST.Add(new Node(150), BST.Root);
            BST.Add(new Node(200), BST.Root);
            BST.Add(new Node(175), BST.Root);
            BST.Add(new Node(35), BST.Root);

            Assert.Equal(expected, BST.Search(BST.Root, value).Value);
        }
        [Theory]
        [InlineData(400)]
        [InlineData(1)]
        [InlineData(125)]
        [InlineData(30)]
        public void ReturnNullIfNoNodeFoundInBinarySearchTree(int value)
        {
            BinarySearchTree BST = new BinarySearchTree(new Node(50));
            BST.Add(new Node(25), BST.Root);
            BST.Add(new Node(150), BST.Root);
            BST.Add(new Node(200), BST.Root);
            BST.Add(new Node(175), BST.Root);
            BST.Add(new Node(35), BST.Root);

            Assert.Null(BST.Search(BST.Root, value));
        }
        [Theory]
        [InlineData(200, 200)]
        [InlineData(25, 25)]
        [InlineData(35, 35)]
        [InlineData(175, 175)]
        public void FindANodeInBinaryTree(int value, int expected)
        {
            BinaryTree binaryTree = new BinaryTree(new Node(50));
            binaryTree.Add(new Node(25), binaryTree.Root);
            binaryTree.Add(new Node(150), binaryTree.Root);
            binaryTree.Add(new Node(200), binaryTree.Root);
            binaryTree.Add(new Node(175), binaryTree.Root);
            binaryTree.Add(new Node(35), binaryTree.Root);

            Assert.Equal(expected, binaryTree.Search(binaryTree.Root, value).Value);
        }
    }
}
