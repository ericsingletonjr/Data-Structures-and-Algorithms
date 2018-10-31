
using System;
using Xunit;
using FindMax;
using FindMax.Classes;

namespace FindMaxTests
{
    public class UnitTest1
    {
        [Fact]
        public void CheckThatTheLargestValueIsFound()
        {
            BinaryTree binaryTree = new BinaryTree(new Node(1));
            binaryTree.Add(new Node(30), binaryTree.Root);
            binaryTree.Add(new Node(20), binaryTree.Root);
            binaryTree.Add(new Node(31), binaryTree.Root);
            binaryTree.Add(new Node(5), binaryTree.Root);

            Assert.Equal(31, Program.FindMaximumValue(binaryTree));
        }
        [Fact]
        public void CheckThatZeroIsReturnedWithEmptyTree()
        {
            BinaryTree binaryTree = new BinaryTree(new Node(0));

            Assert.Equal(0, Program.FindMaximumValue(binaryTree));
        }
        [Fact]
        public void CheckNegativeValueMax()
        {
            BinaryTree binaryTree = new BinaryTree(new Node(-11));
            binaryTree.Add(new Node(-130), binaryTree.Root);
            binaryTree.Add(new Node(-20), binaryTree.Root);
            binaryTree.Add(new Node(-31), binaryTree.Root);
            binaryTree.Add(new Node(-5), binaryTree.Root);

            Assert.Equal(-5, Program.FindMaximumValue(binaryTree));
        }
    }
}
