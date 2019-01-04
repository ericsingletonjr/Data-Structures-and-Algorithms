using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using LList.Classes;

namespace LListTests
{
    public class NodeUnitTests
    {
        [Fact]
        public void NodeInstanceFieldNextGetAndSet()
        {
            Node test = new Node("test");
            Node next = new Node("next");

            Assert.Null(test.Next);
            test.Next = next;
            Assert.Equal(next, test.Next);
        }
        [Fact]
        public void NodeInstanceFieldPreviousGetAndSet()
        {
            Node test = new Node("test");
            Node previous = new Node("previous");

            Assert.Null(test.Previous);
            test.Previous = previous;
            Assert.Equal(previous, test.Previous);
        }
        [Fact]
        public void NodeInstanceFieldValueGetAndSet()
        {
            Node test = new Node("test");

            Assert.Equal("test", test.Value);
            test.Value = "changed";
            Assert.Equal("changed", test.Value);
        }
    }
}
