using System;
using Xunit;
using TreeIntersection;
using TreeIntersection.Classes;
using System.Collections.Generic;

namespace TreeIntersectionTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("5")]
        [InlineData("10")]
        [InlineData("15")]
        [InlineData("20")]
        [InlineData("25")]
        public void TestHelperMethodReturnsUpdatedHashSet(string key)
        {
            HashSet set = new HashSet();
            BinaryTree tree = new BinaryTree(new Node(5));

            tree.Add(new Node(10), tree.Root);
            tree.Add(new Node(15), tree.Root);
            tree.Add(new Node(20), tree.Root);
            tree.Add(new Node(25), tree.Root);

            set = Program.FirstTraversal(tree, set);

            Assert.True(set.ContainsKey(key));
        }
        [Theory]
        [InlineData("5",5)]
        [InlineData("10",10)]
        [InlineData("15",15)]
        [InlineData("20",20)]
        [InlineData("25",25)]
        public void TestHelperMethodStoredCorrectValueInHashSet(string key, int expected)
        {
            HashSet set = new HashSet();
            BinaryTree tree = new BinaryTree(new Node(5));

            tree.Add(new Node(10), tree.Root);
            tree.Add(new Node(15), tree.Root);
            tree.Add(new Node(20), tree.Root);
            tree.Add(new Node(25), tree.Root);

            set = Program.FirstTraversal(tree, set);

            Assert.Equal(expected, set.FindValue(key));
        }
        [Fact]
        public void TestThatSolutionWorksWithVaryingSizedTrees()
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

            List<int> values = Program.TreeIntersect(bt1, bt2);
            Assert.Equal(2, values.Count);
        }
        [Fact]
        public void TestThatSolutionWorksWithNoMatches()
        {
            BinaryTree bt1 = new BinaryTree(new Node(10));
            BinaryTree bt2 = new BinaryTree(new Node(25));

            bt1.Add(new Node(8), bt1.Root);
            bt1.Add(new Node(100), bt1.Root);
            bt1.Add(new Node(200), bt1.Root);
            bt1.Add(new Node(75), bt1.Root);
            bt1.Add(new Node(20), bt1.Root);
            bt1.Add(new Node(150), bt1.Root);

            bt2.Add(new Node(64), bt2.Root);
            bt2.Add(new Node(6000), bt2.Root);
            bt2.Add(new Node(499), bt2.Root);
            bt2.Add(new Node(89), bt2.Root);
            bt2.Add(new Node(1), bt2.Root);
            bt2.Add(new Node(5), bt2.Root);

            List<int> values = Program.TreeIntersect(bt1, bt2);
            Assert.Empty(values);
        }
        [Fact]
        public void MatchWithOnlyRootNode()
        {
            BinaryTree bt1 = new BinaryTree(new Node(10));
            BinaryTree bt2 = new BinaryTree(new Node(10));

            List<int> values = Program.TreeIntersect(bt1, bt2);
            Assert.Single(values);
        }
    }
}
