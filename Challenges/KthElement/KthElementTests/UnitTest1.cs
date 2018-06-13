using System;
using Xunit;
using KthElement.Classes;

namespace KthElementTests
{
    public class UnitTest1
    {
        [Fact]
        public void FindNodeAtFirstValueZero()
        {
            LinkList list = new LinkList(new Node(5));

            list.Add(new Node(10));
            list.Add(new Node(2));
            list.Add(new Node(73));
            list.Add(new Node(20));

            Assert.Equal(5, list.KthElement(0).Value);
        }
        [Theory]
        [InlineData(60)]
        [InlineData(10)]
        [InlineData(1000)]
        public void FindNoNodeAtValueK(int k)
        {
            LinkList list = new LinkList(new Node(5));

            list.Add(new Node(10));
            list.Add(new Node(2));
            list.Add(new Node(73));
            list.Add(new Node(20));

            Assert.Null(list.KthElement(k));
        }
        [Theory]
        [InlineData(4, 20)]
        [InlineData(1,10)]
        [InlineData(3,73)]
        [InlineData(2, 2)]
        public void FindNodeAtValueK(int k, int expected)
        {
            LinkList list = new LinkList(new Node(5));

            list.Add(new Node(10));
            list.Add(new Node(2));
            list.Add(new Node(73));
            list.Add(new Node(20));

            Assert.Equal(expected, list.KthElement(k).Value);
        }
    }
}
