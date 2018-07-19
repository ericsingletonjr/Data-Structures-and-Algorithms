using System;
using LeftJoins.Classes;
using System.Collections.Generic;

namespace LeftJoins
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            HashTable table1 = new HashTable();
            HashTable table2 = new HashTable();

            table1.Add("fond", "enamoured");
            table1.Add("wrath", "anger");
            table1.Add("diligent", "employed");
            table1.Add("outfit", "garb");
            table1.Add("guide", "usher");

            table2.Add("fond", "averse");
            table2.Add("wrath", "delight");
            table2.Add("diligent", "idle");
            table2.Add("flow", "jam");
            table2.Add("guide", "follow");

            List<List<string>> test = LeftJoin(table1, table2);

            foreach(var list in test)
            {
                foreach(var item in list)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine("");
            }
        }
        /// <summary>
        /// Method that takes in two HashMaps and implements a left
        /// joins onto the first table. If there is a match of keys in the second
        /// hashmap, it will attach it's value to the list or it will attach a null
        /// </summary>
        /// <param name="table1">HashMap 1</param>
        /// <param name="table2">HashMap 2</param>
        /// <returns>A list of the newly joined HashMap</returns>
        public static List<List<string>> LeftJoin(HashTable table1, HashTable table2)
        {
            List<List<string>> match = new List<List<string>>();

            foreach(var bucket in table1.Table)
            {
                if(bucket != null)
                {
                    List<string> list = new List<string>
                    {
                        bucket.Key,
                        bucket.Value
                    };
                    match.Add(list);
                }
            }

            foreach(var list in match)
            {
                if (table2.ContainsKey(list[0]))
                {
                    list.Add(table2.FindValue(list[0]));
                }
                else
                {
                    list.Add("NULL");
                }
            }
            return match;
        }
    }
}
