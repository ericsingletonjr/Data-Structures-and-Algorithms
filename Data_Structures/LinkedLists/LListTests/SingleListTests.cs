using LList.Classes;
using System;
using Xunit;

namespace LListTests
{
    public class SingleListTests
    {
        //------CONSTRUCTOR TESTS------\\
        [Fact]
        public void SingleLinkedlistWithASingleNode()
        {
            LListSingle ll = new LListSingle(new Node(1));
            Assert.NotNull(ll.Head);
        }
        [Fact]
        public void SingleLinkedlistWithoutNode()
        {
            LListSingle ll = new LListSingle();
            Assert.Null(ll.Head);
        }
        //------METHOD TESTS------\\
        [Theory]
        [InlineData("Cat")]
        [InlineData("Dog")]
        [InlineData("Test")]
        [InlineData("Hello World")]
        public void AddNodeMethodUpdatesHead(string value)
        {
            LListSingle ll = new LListSingle();
            Node newNode = new Node(value);

            Assert.Null(ll.Head);
            ll.Add(newNode);
            Assert.Equal(value, ll.Head.Value);
        }
        [Theory]
        [InlineData("Cat")]
        [InlineData("Dog")]
        [InlineData("Test")]
        [InlineData("Hello World")]
        public void AddNodeBeforeWhereSpecifiedNodeIsHead(string value)
        {
            Node firstNode = new Node("First");
            LListSingle ll = new LListSingle(firstNode);
            Assert.Equal("First", ll.Head.Value);

            Node newNode = new Node(value);
            ll.AddNodeBefore(newNode, firstNode);
            Assert.Equal(value, ll.Head.Value);
        }
        [Theory]
        [InlineData("Cat")]
        [InlineData("Dog")]
        [InlineData("Test")]
        [InlineData("Hello World")]
        public void AddNodeBeforeWhereSpecifiedNodeIsTrue(string value)
        {
            Node firstNode = new Node("First");
            Node secondNode = new Node("Second");
            Node thirdNode = new Node("Third");
            LListSingle ll = new LListSingle(firstNode);
            ll.Add(secondNode);
            ll.Add(thirdNode);

            Node newNode = new Node(value);
            var IsSuccessful = ll.AddNodeBefore(newNode, firstNode);

            Assert.True(IsSuccessful);
            Assert.Equal(secondNode.Next, newNode);
        }
        [Theory]
        [InlineData("Cat")]
        [InlineData("Dog")]
        [InlineData("Test")]
        [InlineData("Hello World")]
        public void AddNodeBeforeWhereSpecifiedNodeIsFalse(string value)
        {
            Node firstNode = new Node("First");
            Node secondNode = new Node("Second");
            Node thirdNode = new Node("Third");
            Node randomNode = new Node("Nope");
            LListSingle ll = new LListSingle(firstNode);
            ll.Add(secondNode);
            ll.Add(thirdNode);

            Node newNode = new Node(value);
            var IsSuccessful = ll.AddNodeBefore(newNode, randomNode);
            Assert.False(IsSuccessful);
        }
        [Theory]
        [InlineData("Cat")]
        [InlineData("Dog")]
        [InlineData("Test")]
        [InlineData("Hello World")]
        public void AddNodeAfterWhereSpecifiedNodeIsHead(string value)
        {
            Node firstNode = new Node("First");
            LListSingle ll = new LListSingle(firstNode);
            Assert.Equal("First", ll.Head.Value);

            Node newNode = new Node(value);
            ll.AddNodeAfter(newNode, firstNode);

            Assert.Equal(value, ll.Head.Next.Value);
            Assert.Equal(ll.Head.Value, firstNode.Value);
        }
        [Theory]
        [InlineData("Cat")]
        [InlineData("Dog")]
        [InlineData("Test")]
        [InlineData("Hello World")]
        public void AddNodeAfterWhereSpecifiedNodeIsTrue(string value)
        {
            Node firstNode = new Node("First");
            Node secondNode = new Node("Second");
            Node thirdNode = new Node("Third");
            LListSingle ll = new LListSingle(firstNode);
            ll.Add(secondNode);
            ll.Add(thirdNode);

            Node newNode = new Node(value);
            var IsSuccessful = ll.AddNodeAfter(newNode, firstNode);

            Assert.True(IsSuccessful);
            Assert.Equal(firstNode.Next, newNode);
        }
        [Theory]
        [InlineData("Cat")]
        [InlineData("Dog")]
        [InlineData("Test")]
        [InlineData("Hello World")]
        public void AddNodeAfterWhereSpecifiedNodeIsFalse(string value)
        {
            Node firstNode = new Node("First");
            Node secondNode = new Node("Second");
            Node thirdNode = new Node("Third");
            Node randomNode = new Node("Nope");
            LListSingle ll = new LListSingle(firstNode);
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
            LListSingle ll = new LListSingle();
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
            LListSingle ll = new LListSingle(new Node("first"));
            Node second = new Node("second");
            Node third = new Node("Third");
            ll.Add(second);
            ll.Add(third);

            var removed = ll.Remove();
            Assert.Equal(third, removed);
        }
        [Fact]
        public void RemoveSpecificNodeFromFrontIfHead()
        {
            LListSingle ll = new LListSingle();
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
        public void RemoveSpecificNodeFromList()
        {
            LListSingle ll = new LListSingle();
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
            LListSingle ll = new LListSingle();
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
            LListSingle ll = new LListSingle();
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
        public void FindSpecificNodeIsFalse()
        {
            LListSingle ll = new LListSingle();
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
    }
}