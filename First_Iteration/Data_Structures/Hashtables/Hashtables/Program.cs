using System;
using Hashtables.Classes;

namespace Hashtables
{
    class Program
    {
        static void Main(string[] args)
        {
            HashTable table = new HashTable();

            //Add a set of key/value pairs
            table.Add("Cat", 20);
            table.Add("Zebra", 245);
            table.Add("Tele", 3409);
            table.Add("Frank", 6);

            //Get Hash values of all added keys
            Console.WriteLine("----HashTable-----");
            Console.WriteLine(table.GetHash("Cat") + " is Cat");
            Console.WriteLine(table.GetHash("Zebra") + " is Zebra");
            Console.WriteLine(table.GetHash("Tele") + " is Tele");
            Console.WriteLine(table.GetHash("Frank") + " is Frank");
            Console.WriteLine("-----");

            //Check if keys exist in the Hash table
            Console.WriteLine(table.ContainsKey("Cat"));
            Console.WriteLine(table.ContainsKey("Zebra"));
            Console.WriteLine(table.ContainsKey("Tele"));
            Console.WriteLine(table.ContainsKey("Frank"));
            Console.WriteLine("Key Doe: currently isn't in the table");
            Console.WriteLine(table.ContainsKey("Doe"));
            Console.WriteLine("-----");

            //Find the values of a given keys
            Console.WriteLine(table.FindValue("Cat"));
            Console.WriteLine(table.FindValue("Zebra"));
            Console.WriteLine(table.FindValue("Tele"));
            Console.WriteLine(table.FindValue("Frank"));
            Console.WriteLine("-----");

            //Add a key that creates collision 
            table.Add("Doe", 25);
            Console.WriteLine(table.GetHash("Doe") + " is Doe");
            Console.WriteLine(table.GetHash("Cat") + " is Cat");
            Console.WriteLine(table.ContainsKey("Doe"));
            Console.WriteLine("-----");

            //Can still find a value even if the buckets are linked
            Console.WriteLine(table.FindValue("Cat"));
            Console.WriteLine(table.FindValue("Doe"));
            Console.WriteLine(table.ContainsKey("Cat"));
            Console.WriteLine(table.ContainsKey("Doe"));
            Console.WriteLine("-----");
            try
            {
                table.Add("Cat", 50);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("----HashSet-----");

            //HashSet
            HashSet hashSet = new HashSet();

            hashSet.Add("Cat", 20);
            hashSet.Add("Zebra", 245);

            Console.WriteLine(hashSet.ContainsKey("Cat"));
            Console.WriteLine(hashSet.ContainsKey("Zebra"));
            Console.WriteLine(hashSet.ContainsKey("Doe"));
            Console.WriteLine("---");
            //Throw error with collision
            try
            {
                hashSet.Add("Doe", 5);
            }
            catch (Exception)
            {
                Console.WriteLine("Index already has a value");
            }
            Console.WriteLine(table.FindValue("Cat"));
            Console.WriteLine(table.FindValue("Zebra"));
        }
    }
}
