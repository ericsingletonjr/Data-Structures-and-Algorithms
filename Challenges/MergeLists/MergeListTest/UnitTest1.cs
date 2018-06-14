using System;
using Xunit;
using MergeLists;
using MergeLists.Classes;

namespace MergeListTest
{
    public class UnitTest1
    {
        [Fact]
        public void NewListDoesNotReturnNull()
        {
            LinkList listOne = new LinkList(new Node(3));
            listOne.Add(new Node(8));
            listOne.Add(new Node(23));
            listOne.Add(new Node(9));

            LinkList listTwo = new LinkList(new Node(45));
            listTwo.Add(new Node(16));

            LinkList listThree = Program.Merge(listOne, listTwo);
            Assert.NotNull(listThree);
        }
        [Fact]
        public void NewMergeListHeadIsTheSameAsTheFirstInputtedLinkedListHead()
        {
            LinkList listOne = new LinkList(new Node(3));
            listOne.Add(new Node(8));
            listOne.Add(new Node(23));

            LinkList listTwo = new LinkList(new Node(45));
            listTwo.Add(new Node(16));
            listTwo.Add(new Node(5));

            LinkList listThree = Program.Merge(listOne, listTwo);
            Assert.Equal(listThree.Head.Value, listOne.Head.Value);
        }
        [Fact]
        public void NewMergeListSeconNodeIsTheSameAsTheSecondInputtedLinkedListHead()
        {
            LinkList listOne = new LinkList(new Node(3));
            listOne.Add(new Node(8));
            listOne.Add(new Node(23));

            LinkList listTwo = new LinkList(new Node(45));
            listTwo.Add(new Node(16));
            listTwo.Add(new Node(5));

            LinkList listThree = Program.Merge(listOne, listTwo);
            listThree.Current = listThree.Head;
            Assert.Equal(listThree.Current.Next.Value, listTwo.Head.Value);
        }
    }
}
