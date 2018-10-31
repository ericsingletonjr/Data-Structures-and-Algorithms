using System;
using LinkedLists.Classes;

namespace LinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            TestLL();
        }

        static void TestLL()
        {
            LinkList list = new LinkList(new Node(5));
            list.Add(new Node(10));
            list.Add(new Node(25));
            list.Add(new Node(50));
            list.Print();

            Node found = list.Find(10);
            Console.WriteLine($"Node value found: {found.Value}");

            Console.WriteLine($"Let's add a node before {found.Value}");
            list.AddBefore(new Node(26), found);           
            list.Print();
            Console.WriteLine("-----");

            Console.WriteLine($"Let's add a node after {found.Value}");
            Console.WriteLine($"Node value found: {found.Value}");
            list.AddAfter(new Node(30), found);
            list.Print();
            Console.WriteLine("-----");

            Console.WriteLine("Lets add a node at the end");
            list.AddLast(new Node(1));
            list.Print();
        }
    }
}
