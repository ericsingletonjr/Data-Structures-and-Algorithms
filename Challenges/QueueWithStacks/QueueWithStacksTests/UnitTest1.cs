using System;
using Xunit;
using QueueWithStacks.Classes;

namespace QueueWithStacksTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(5, 5)]
        [InlineData(25, 25)]
        [InlineData(30, 30)]
        [InlineData(2, 2)]
        public void FrontOfQueueIsBottomOfStackOne(int value, int expected)
        {
            Stack stackOne = new Stack(new Node(value));
            stackOne.Push(new Node(2));

            Stack stackTwo = new Stack(new Node(6));
            stackTwo.Push(new Node(7));
            stackTwo.Push(new Node(8));

            Queue queue = new Queue(stackOne, stackTwo);

            Assert.Equal(expected, queue.Front.Value);
        }
        [Theory]
        [InlineData(5, 5)]
        [InlineData(25, 25)]
        [InlineData(30, 30)]
        [InlineData(2, 2)]
        public void NewEnqueuedValueEqualsStackOneTop(int value, int expected)
        {
            Stack stackOne = new Stack(new Node(1));
            stackOne.Push(new Node(2));

            Stack stackTwo = new Stack(new Node(6));
            stackTwo.Push(new Node(7));
            stackTwo.Push(new Node(8));

            Queue queue = new Queue(stackOne, stackTwo);

            queue.Enqueue(new Node(value));

            Assert.Equal(expected, stackOne.Top.Value);
        }
        [Theory]
        [InlineData(5, 5)]
        [InlineData(25, 25)]
        [InlineData(30, 30)]
        [InlineData(2, 2)]
        public void FrontIsNewBottomOfStackOneAfterDequeue(int value, int expected)
        {
            Stack stackOne = new Stack(new Node(value));
            stackOne.Push(new Node(2));

            Stack stackTwo = new Stack(new Node(6));
            stackTwo.Push(new Node(7));
            stackTwo.Push(new Node(8));

            Queue queue = new Queue(stackOne, stackTwo);

            Node dequeued = queue.Dequeue();

            Assert.Equal(expected, dequeued.Value);
            Assert.Equal(2, queue.Front.Value);
        }
    }
}
