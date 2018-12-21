using System;
using LList.Classes;

namespace LList
{
    class Program
    {
        static void Main(string[] args)
        {
            LListSingle lListSingle = new LListSingle(new Node("first"));
            lListSingle.Add(new Node(4));
            lListSingle.Add(new Node("eight"));
            lListSingle.Add(new Node("cat"));
            lListSingle.Add(new Node(2));
            lListSingle.Print();

            Console.WriteLine($"Finding middle of list: {lListSingle.MiddleOfList().Value}");
            Console.WriteLine("===");

            Console.WriteLine($"Find if Value first exists: {lListSingle.Find("first")}");
            Console.WriteLine("====");

            Node test = lListSingle.Remove();
            Console.WriteLine($"Removed Node Value: {test.Value}");
            Console.WriteLine($"Find if Value exists: {lListSingle.Find(2)}");
            Console.WriteLine("====");

            lListSingle.Print();
            Console.WriteLine("====");

            Node test2 = lListSingle.RemoveNode("first");
            Console.WriteLine($"Removed Node Value: {test2.Value}");
            Console.WriteLine($"Find if Value exists: {lListSingle.Find("first")}");
            Console.WriteLine("====");

            lListSingle.Print();
        }
    }
}
