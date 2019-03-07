using System;
using PriorityQueue.Classes;

namespace PriorityQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Node node1 = new Node(1, 2);
            Node node2 = new Node(3, 2);
            Node node3 = new Node(6, 50);
            Node node4 = new Node(20, 5);
            Node node5 = new Node(6, 3);

            PriorityQ pQ = new PriorityQ();

            Console.WriteLine($"Is queue empty? {pQ.IsEmpty()}");

            pQ.Enqueue(node1);
            pQ.Enqueue(node2);
            pQ.Enqueue(node3);
            pQ.Enqueue(node4);
            pQ.Enqueue(node5);

            Console.WriteLine("------------------");
            Console.WriteLine($"Is queue empty? {pQ.IsEmpty()}");

            pQ.Print();
            Console.WriteLine($"Current Highest Priority: {pQ.HighestPriority}");
            Console.WriteLine($"Current Back: {pQ.Back.Value} | Current Front: {pQ.Front.Value}");
            Console.WriteLine("------------------");

            Node test = pQ.Dequeue();
            pQ.Print();
            Console.WriteLine($"Removed Node: {test.Value} | Priority: {test.Priority}");
            Console.WriteLine($"Current Highest Priority: {pQ.HighestPriority}");
        }
    }
}
