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

            Node test = lListSingle.Remove();
            Console.WriteLine(test.Value);
            lListSingle.Print();
        }
    }
}
