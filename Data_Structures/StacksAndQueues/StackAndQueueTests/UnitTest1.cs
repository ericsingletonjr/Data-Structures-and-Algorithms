using System;
using Xunit;
using StackAndQueue.Classes;

namespace StackAndQueueTests
{
    public class UnitTest1
    {
        [Fact]
        public void PushingANodeToTheStack()
        {
            Stack stack = new Stack(new Node(1));
            stack.Push(new Node(3));
            stack.Push(new Node(5));
            stack.Push(new Node(7));

            Assert.Equal(7, stack.Peek().Value);
        }
        [Fact]
        public void PoppingANodeFromTheStack()
        {
            Stack stack = new Stack(new Node(1));
            stack.Push(new Node(3));
            stack.Push(new Node(5));
            stack.Push(new Node(7));

            Assert.Equal(7, stack.Pop().Value);
            Assert.Equal(5, stack.Peek().Value);
        }
        [Fact]
        public void PeekAlwaysReturnsTopValueOfStackProvingLastInFirstOut()
        {
            Stack stack = new Stack(new Node(1));
            Assert.Equal(1, stack.Peek().Value);

            stack.Push(new Node(3));
            Assert.Equal(3, stack.Peek().Value);

            stack.Push(new Node(5));
            Assert.Equal(5, stack.Peek().Value);

            stack.Push(new Node(7));
            Assert.Equal(7, stack.Peek().Value);

        }
        [Fact]
        public void EnqueuingANodeToTheQueue()
        {
            Queue queue = new Queue(new Node(2));
            queue.Enqueue(new Node(4));
            queue.Enqueue(new Node(6));
            queue.Enqueue(new Node(8));

            Assert.Equal(2, queue.Peek().Value);
        }
        [Fact]
        public void DequeuingANodeFromTheQueue()
        {
            Queue queue = new Queue(new Node(2));
            queue.Enqueue(new Node(4));
            queue.Enqueue(new Node(6));
            queue.Enqueue(new Node(8));

            
            Assert.Equal(2, queue.Dequeue().Value);
            Assert.Equal(4, queue.Peek().Value);
        }
        [Fact]
        public void PeekAlwaysReturnsFrontOfQueueProvingFirstInFirstOut()
        {
            Queue queue = new Queue(new Node(2));
            queue.Enqueue(new Node(4));
            queue.Enqueue(new Node(6));
            queue.Enqueue(new Node(8));

            Assert.Equal(2, queue.Peek().Value);
            queue.Dequeue();
            Assert.Equal(4, queue.Peek().Value);
            queue.Dequeue();
            Assert.Equal(6, queue.Peek().Value);
            queue.Dequeue();
            Assert.Equal(8, queue.Peek().Value);
        }
    }
}
