using System;
using System.Collections.Generic;
using System.Text;

namespace QueueWithStacks.Classes
{
    public class Queue
    {
        public Node Front { get; set; }
        public Stack StackOne { get; set; }
        public Stack StackTwo { get; set; }

        public Queue(Stack stackOne, Stack stackTwo)
        {
            StackOne = stackOne;
            StackTwo = stackTwo;
            Front = Peek();
        }
        /// <summary>
        /// Method uses the Stack method Push to emulate adding to the
        /// back of a queue
        /// </summary>
        /// <param name="node">New node to be added</param>
        public void Enqueue(Node node)
        {
            StackOne.Push(node);
        }
        /// <summary>
        /// Method uses the Stack Push and Pop methods to emulate FIFO.
        /// It will move all values from StackOne to StackTwo, pop and store the top
        /// from StackTwo and then proceed to re-fill StackOne to ensure Queue-Like
        /// Order
        /// </summary>
        /// <returns>Node that is removed</returns>
        public Node Dequeue()
        {
            while (StackOne.Peek() != null)
            {
                StackTwo.Push(StackOne.Pop());
            }
            Node popped = StackTwo.Pop();
            Front = StackTwo.Top;
            while (StackTwo.Peek() != null)
            {
                StackOne.Push(StackTwo.Pop());
            }
            return popped;
        }
        /// <summary>
        /// Method finds the beginning of the "Queue" or
        /// bottom of StackOne
        /// </summary>
        /// <returns></returns>
        public Node Peek()
        {
            while(StackOne.Peek() != null)
            {
                StackTwo.Push(StackOne.Pop());
            }
            Front = StackTwo.Top;
            while(StackTwo.Peek() != null)
            {
                StackOne.Push(StackTwo.Pop());
            }
            return Front;
        }
        /// <summary>
        /// Method to print the Stack for the purpose of
        /// showing correct FIFO principles
        /// </summary>
        public void Print()
        {
            Node Current = StackOne.Top;
            while(Current.Next != null)
            {
                Console.Write($"{Current.Value}-->");
                Current = Current.Next;
            }
            Console.Write($"{Current.Value}-->NULL");
            Console.WriteLine(" ");
        }
    }
}
