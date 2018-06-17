﻿using System;
using StackAndQueue.Classes;

namespace StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Stack();
            Queue();
        }

        static void Stack()
        {
            Stack stack = new Stack(new Node(1));
            stack.Push(new Node(3));
            stack.Push(new Node(5));
            stack.Push(new Node(7));

            stack.Print();
            Console.WriteLine(stack.Peek().Value);

            stack.Pop();
            stack.Print();
            Console.WriteLine(stack.Peek().Value);
        }

        static void Queue()
        {
            Queue queue = new Queue(new Node(2));
            queue.Enqueue(new Node(4));
            queue.Enqueue(new Node(6));
            queue.Enqueue(new Node(8));

            queue.Print();
            Console.WriteLine(queue.Peek().Value);

            queue.Dequeue();
            queue.Print();
            Console.WriteLine(queue.Peek().Value);
        }
    }
}
