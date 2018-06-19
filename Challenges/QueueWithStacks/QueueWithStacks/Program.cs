using QueueWithStacks.Classes;
using System;

namespace QueueWithStacks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            QueueWithStacks();
        }
        static void QueueWithStacks()
        {
            Stack stackOne = new Stack(new Node(5));
            stackOne.Push(new Node(3));
            stackOne.Push(new Node(7));
            Stack stackTwo = new Stack(new Node(10));
            stackTwo.Push(new Node(12));
            Queue queue = new Queue(stackOne, stackTwo);

            queue.Print();
            queue.Enqueue(new Node(35));

            queue.Print();
            queue.Dequeue();
            queue.Print();
        }
    }
}
