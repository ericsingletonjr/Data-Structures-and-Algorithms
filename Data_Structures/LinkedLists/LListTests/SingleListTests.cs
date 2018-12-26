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
    }
}
