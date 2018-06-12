using System;
using Xunit;
using LinkedLists;
using LinkedLists.Classes;

namespace LinkedListsTests
{
    public class UnitTest1
    {
        [Fact]
        public void AddNodeToFrontOfList()
        {
            LinkList list = new LinkList(new Node(1));

            Node node = new Node(2);
            Node node2 = new Node(3);

            list.Add(node);
            list.Add(node2);

            Assert.Equal(list.Head.Value, node2.Value);
        }
        [Fact]
        public void AddNodeToEndOfList()
        {
            Node head = new Node(1);
            LinkList list = new LinkList(new Node(1));

            Node node = new Node(2);
            Node node2 = new Node(3);

            list.AddLast(node);
            list.AddLast(node2);

            Assert.Equal(list.Head.Value, head.Value);
        }
        [Theory]
        [InlineData(6, 6)]
        [InlineData(24, 24)]
        [InlineData(2, 2)]
        [InlineData(3, 3)]
        public void FindExistingNodeInList(int findNode, int expected)
        {
            LinkList list = new LinkList(new Node(1));
            Node node = new Node(2);
            Node node2 = new Node(3);
            Node node3= new Node(6);
            Node node4 = new Node(12);
            Node node5 = new Node(24);

            list.Add(node);
            list.Add(node2);
            list.Add(node3);
            list.Add(node4);
            list.Add(node5);

            Node found = list.Find(findNode);

            Assert.Equal(expected, found.Value);
        }
        [Theory]
        [InlineData(20)]
        [InlineData(99)]
        [InlineData(232)]
        public void DoesNotFindAnExistingNode(int findNode)
        {
            LinkList list = new LinkList(new Node(1));
            Node node = new Node(2);
            Node node2 = new Node(3);
            Node node3 = new Node(6);
            Node node4 = new Node(12);
            Node node5 = new Node(24);

            list.Add(node);
            list.Add(node2);
            list.Add(node3);
            list.Add(node4);
            list.Add(node5);

            Node found = list.Find(findNode);

            Assert.Null(found);
        }
    }
}
