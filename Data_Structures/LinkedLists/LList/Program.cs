using System;
using LList.Classes;

namespace LList
{
    class Program
    {
        static void Main(string[] args)
        {
            LListSingle lListSingle = new LListSingle(new Node("first"));
            lListSingle.Add(new Node(2));
            lListSingle.Print();

            Console.WriteLine($"Find if Value first exists: {lListSingle.Find("first")}");
            Console.WriteLine("====");

            Node test = lListSingle.Remove();
            Console.WriteLine($"Removed Node Value: {test.Value}");
            Console.WriteLine($"Find if Value 2 exists: {lListSingle.Find(2)}");
            Console.WriteLine("====");

            lListSingle.Print();
        }
    }
}
