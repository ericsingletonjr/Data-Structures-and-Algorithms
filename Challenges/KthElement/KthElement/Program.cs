using System;
using KthElement.Classes;

namespace KthElement
{
    class Program
    {
        static void Main(string[] args)
        {          
            Console.WriteLine(KthElement(3).Value);
        }

        public static Node KthElement(int k)
        {
            LinkList list = new LinkList(new Node(5));

            list.Add(new Node(10));
            list.Add(new Node(2));
            list.Add(new Node(73));
            list.Add(new Node(20));

            list.Print();

            return list.KthElement(k);
        }
    }
}
