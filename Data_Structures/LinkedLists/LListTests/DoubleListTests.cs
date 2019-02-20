using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using LList.Classes;

namespace LListTests
{
    public class DoubleListTests
    {
        //------CONSTRUCTOR TESTS------\\
        [Fact]
        public void InstantiateDoubleListWithoutNode()
        {
            LListDouble ll = new LListDouble();
            Assert.Null(ll.Head);
        }
        [Fact]
        public void InstantiateDoubleListWithNode()
        {
            Node first = new Node("first");
            LListDouble ll = new LListDouble(first);
            Assert.Equal(first, ll.Head);
        }
        //------METHOD TESTS------\\
        [Theory]
        [InlineData("cat")]
        [InlineData(6)]
        [InlineData("eight")]
        [InlineData(2)]
        [InlineData("banana")]
        public void AddNodeUpdateTheHead(object value)
        {
            LListDouble ll = new LListDouble();
            Node newNode = new Node(value);

            Assert.Null(ll.Head);
            ll.Add(newNode);
            Assert.Equal(value, ll.Head.Value);
        }
        [Fact]
        public void AddNodeWithChainingMethod()
        {
            LListDouble ll = new LListDouble();
            Node newNode = new Node("cat");
            Node newNode2 = new Node(6);
            Node newNode3 = new Node("eight");
            Node newNode4 = new Node(2);
            Assert.Null(ll.Head);
            ll.AddNode(newNode)
              .AddNode(newNode2)
              .AddNode(newNode3)
              .AddNode(newNode4);
            Assert.Equal(2, ll.Head.Value);
        }
        [Theory]
        [InlineData("cat")]
        [InlineData(6)]
        [InlineData("eight")]
        [InlineData(2)]
        [InlineData("banana")]
        public void AddNodeBeforeWhereSpecifiedNodeIsHead(object value)
        {
            Node firstNode = new Node("First");
            LListDouble ll = new LListDouble(firstNode);
            Assert.Equal("First", ll.Head.Value);

            Node newNode = new Node(value);
            ll.AddNodeBefore(newNode, firstNode);
            Assert.Equal(value, ll.Head.Value);
        }
        [Theory]
        [InlineData("cat")]
        [InlineData(6)]
        [InlineData("eight")]
        [InlineData(2)]
        [InlineData("banana")]
        public void AddNodeBeforeWhereSpecifiedNodeIsTrue(object value)
        {
            Node firstNode = new Node("First");
            Node secondNode = new Node("Second");
            Node thirdNode = new Node("Third");
            LListDouble ll = new LListDouble(firstNode);
            ll.Add(secondNode);
            ll.Add(thirdNode);

            Node newNode = new Node(value);
            var IsSuccessful = ll.AddNodeBefore(newNode, firstNode);

            Assert.True(IsSuccessful);
            Assert.Equal(secondNode.Next, newNode);
        }
        [Theory]
        [InlineData("cat")]
        [InlineData(6)]
        [InlineData("eight")]
        [InlineData(2)]
        [InlineData("banana")]
        public void AddNodeBeforeWhereSpecifiedNodeIsFalse(object value)
        {
            Node firstNode = new Node("First");
            Node secondNode = new Node("Second");
            Node thirdNode = new Node("Third");
            Node randomNode = new Node("Nope");
            LListDouble ll = new LListDouble(firstNode);
            ll.Add(secondNode);
            ll.Add(thirdNode);

            Node newNode = new Node(value);
            var IsSuccessful = ll.AddNodeBefore(newNode, randomNode);
            Assert.False(IsSuccessful);
        }
        [Theory]
        [InlineData("cat")]
        [InlineData(6)]
        [InlineData("eight")]
        [InlineData(2)]
        [InlineData("banana")]
        public void AddNodeAfterWhereSpecifiedNodeIsHead(object value)
        {
            Node firstNode = new Node("First");
            LListDouble ll = new LListDouble(firstNode);
            Assert.Equal("First", ll.Head.Value);

            Node newNode = new Node(value);
            ll.AddNodeAfter(newNode, firstNode);

            Assert.Equal(value, ll.Head.Next.Value);
            Assert.Equal(ll.Head.Value, firstNode.Value);
        }
        [Theory]
        [InlineData("cat")]
        [InlineData(6)]
        [InlineData("eight")]
        [InlineData(2)]
        [InlineData("banana")]
        public void AddNodeAfterWhereSpecifiedNodeIsHeadAndNextIsNotNull(object value)
        {
            Node firstNode = new Node("First");
            Node secondNode = new Node("Second");
            LListDouble ll = new LListDouble(firstNode);
            ll.Add(secondNode);
            Assert.Equal("Second", ll.Head.Value);

            Node newNode = new Node(value);
            ll.AddNodeAfter(newNode, secondNode);

            Assert.Equal(value, ll.Head.Next.Value);
            Assert.Equal(ll.Head.Value, secondNode.Value);
        }
        [Theory]
        [InlineData("cat")]
        [InlineData(6)]
        [InlineData("eight")]
        [InlineData(2)]
        [InlineData("banana")]
        public void AddNodeAfterWhereSpecifiedNodeIsTheEndOfTheList(object value)
        {
            Node firstNode = new Node("First");
            Node secondNode = new Node("Second");
            Node thirdNode = new Node("Third");
            LListDouble ll = new LListDouble(firstNode);
            ll.Add(secondNode);
            ll.Add(thirdNode);

            Node newNode = new Node(value);
            var IsSuccessful = ll.AddNodeAfter(newNode, firstNode);

            Assert.True(IsSuccessful);
            Assert.Equal(firstNode.Next, newNode);
        }
        [Theory]
        [InlineData("cat")]
        [InlineData(6)]
        [InlineData("eight")]
        [InlineData(2)]
        [InlineData("banana")]
        public void AddNodeAfterWhereSpecifiedNodeIsTrue(object value)
        {
            Node firstNode = new Node("First");
            Node secondNode = new Node("Second");
            Node thirdNode = new Node("Third");
            LListDouble ll = new LListDouble(firstNode);
            ll.Add(secondNode);
            ll.Add(thirdNode);

            Node newNode = new Node(value);
            var IsSuccessful = ll.AddNodeAfter(newNode, secondNode);

            Assert.True(IsSuccessful);
            Assert.Equal(secondNode.Next, newNode);
        }
        [Theory]
        [InlineData("cat")]
        [InlineData(6)]
        [InlineData("eight")]
        [InlineData(2)]
        [InlineData("banana")]
        public void AddNodeAfterWhereSpecifiedNodeIsFalse(object value)
        {
            Node firstNode = new Node("First");
            Node secondNode = new Node("Second");
            Node thirdNode = new Node("Third");
            Node randomNode = new Node("Nope");
            LListDouble ll = new LListDouble(firstNode);
            ll.Add(secondNode);
            ll.Add(thirdNode);

            Node newNode = new Node(value);
            var IsSuccessful = ll.AddNodeAfter(newNode, randomNode);
            Assert.False(IsSuccessful);
        }
        [Fact]
        public void FindTheMiddleOfATheList()
        {
            Node first = new Node("First");
            LListDouble ll = new LListDouble();
            Node second = new Node("Second");
            Node third = new Node("Third");
            Node fourth = new Node("Fourth");
            Node fifth = new Node("Fifth");

            ll.Add(first);
            ll.Add(second);
            ll.Add(third);
            ll.Add(fourth);
            ll.Add(fifth);

            var middle = ll.MiddleOfList();
            Assert.Equal(third, middle);
        }
        [Fact]
        public void RemoveNodeFromFrontOfList()
        {
            LListDouble ll = new LListDouble(new Node("first"));
            Node second = new Node("second");
            Node third = new Node("Third");
            ll.Add(second);
            ll.Add(third);

            var removed = ll.RemoveHead();
            Assert.Equal(third, removed);
        }
        [Fact]
        public void RemoveNodeFromEndOfList()
        {
            Node first = new Node("first");
            LListDouble ll = new LListDouble(first);
            Node second = new Node("second");
            Node third = new Node("Third");
            ll.Add(second);
            ll.Add(third);

            var removed = ll.RemoveTail();
            Assert.Equal(first, removed);
        }
        [Fact]
        public void RemoveSpecificNodeFromFrontIfHead()
        {
            LListDouble ll = new LListDouble();
            Node first = new Node("First");
            Node second = new Node("Second");
            Node third = new Node("Third");

            ll.Add(first);
            ll.Add(second);
            ll.Add(third);

            var removed = ll.RemoveNode("Third");
            Assert.Equal(third, removed);
        }
        [Fact]
        public void RemoveSpecificNodeFromBackIfTail()
        {
            LListDouble ll = new LListDouble();
            Node first = new Node("First");
            Node second = new Node("Second");
            Node third = new Node("Third");

            ll.Add(first);
            ll.Add(second);
            ll.Add(third);

            var removed = ll.RemoveNode("First");
            Assert.Equal(first, removed);
        }
        [Fact]
        public void RemoveSpecificNodeFromList()
        {
            LListDouble ll = new LListDouble();
            Node first = new Node("First");
            Node second = new Node("Second");
            Node third = new Node("Third");
            Node fourth = new Node("Fourth");

            ll.Add(first);
            ll.Add(second);
            ll.Add(third);
            ll.Add(fourth);

            var removed = ll.RemoveNode("Third");

            Assert.Equal(third, removed);
            Assert.Equal(second, ll.Head.Next);
        }
        [Fact]
        public void RemoveSpecificNodeDoesntExist()
        {
            LListDouble ll = new LListDouble();
            Node first = new Node("First");
            Node second = new Node("Second");
            Node third = new Node("Third");
            Node fourth = new Node("Fourth");

            ll.Add(first);
            ll.Add(second);
            ll.Add(third);
            ll.Add(fourth);

            var removed = new Node("setup");
            try
            {
                removed = ll.RemoveNode("Bob");
            }
            catch
            {
                removed = null;
            }
            Assert.Null(removed);
        }
        [Fact]
        public void FindSpecificNodeIsTrue()
        {
            LListDouble ll = new LListDouble();
            Node first = new Node("First");
            Node second = new Node("Second");
            Node third = new Node("Third");
            Node fourth = new Node("Fourth");

            ll.Add(first);
            ll.Add(second);
            ll.Add(third);
            ll.Add(fourth);

            var find = ll.Find("Second");
            Assert.True(find);
        }
        [Fact]
        public void FindSpecificNodeIsTrueAndTail()
        {
            LListDouble ll = new LListDouble();
            Node first = new Node("First");
            Node second = new Node("Second");
            Node third = new Node("Third");
            Node fourth = new Node("Fourth");

            ll.Add(first);
            ll.Add(second);
            ll.Add(third);
            ll.Add(fourth);

            var find = ll.Find("First");
            Assert.True(find);
        }
        [Fact]
        public void FindSpecificNodeIsFalse()
        {
            LListDouble ll = new LListDouble();
            Node first = new Node("First");
            Node second = new Node("Second");
            Node third = new Node("Third");
            Node fourth = new Node("Fourth");

            ll.Add(first);
            ll.Add(second);
            ll.Add(third);
            ll.Add(fourth);

            var find = ll.Find("Bob");
            Assert.False(find);
        }
        [Fact]
        public void CheckPrintMethodForCodeCoverage()
        {
            LListDouble ll = new LListDouble();
            ll.AddNode(new Node("a"))
              .AddNode(new Node("b"))
              .AddNode(new Node("c"));
            ll.Print();
        }
    }
}
