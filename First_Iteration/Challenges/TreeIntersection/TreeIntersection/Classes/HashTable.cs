using System;
using System.Collections.Generic;
using System.Text;

namespace TreeIntersection.Classes
{
    public class HashTable
    {
        public Bucket[] Table { get; set; }
        public Bucket Current { get; set; }

        public HashTable()
        {
            Table = new Bucket[1024];
        }
        /// <summary>
        /// Method that takes in a key/value pair
        /// and the hashes them to find the appropriate index to assign.
        /// If a collision happens, the new bucket references the existing bucket
        /// and then is placed at the front of the list for an O(1) insertion
        /// </summary>
        /// <param name="key">Key</param>
        /// <param name="value">Value</param>
        public virtual void Add(string key, int value)
        {
            Bucket bucket = new Bucket(key, value);
            int hash = GetHash(key);
            if (ContainsKey(key))
            {
                throw new Exception(message: "This key already exists");
            }
            if (Table[hash] != null)
            {
                bucket.Next = Table[hash];
            }
            Table[hash] = bucket;
        }
        /// <summary>
        /// Method that takes in a key and finds the value
        /// associated with it. In the event that the 
        /// </summary>
        /// <param name="key">Key</param>
        /// <returns>0 if no match, or the value associated with tthe key</returns>
        public int FindValue(string key)
        {
            int hash = GetHash(key);
            Current = Table[hash];
            if (Current == null) return 0;
            while (Current.Next != null)
            {
                if (Current.Key == key) return Current.Value;
                Current = Current.Next;
            }
            if (Current.Key == key) return Current.Value;
            return 0;
        }
        /// <summary>
        /// Method that checks to see if the key exists within 
        /// the HashTable
        /// </summary>
        /// <param name="key">Key</param>
        /// <returns>True or False depending on if the key exists</returns>
        public bool ContainsKey(string key)
        {
            int hash = GetHash(key);
            Current = Table[hash];
            if (Current == null) return false;
            while (Current.Next != null)
            {
                if (Current.Key == key) return true;
                Current = Current.Next;
            }
            if (Current.Key == key) return true;
            return false;
        }
        /// <summary>
        /// Method that is our hashing algorithm. It takes in a key
        /// and adds the ascii characters together. It then multiplies it
        /// by a large prime number and divides it by the length of the Table.
        /// Rounded to nearest integer
        /// </summary>
        /// <param name="key">Key</param>
        /// <returns>Assigned index</returns>
        public int GetHash(string key)
        {
            int value = 0;
            for (int i = 0; i < key.Length; i++)
            {
                value += key[i];
            }
            value = (value * 599) / Table.Length;
            return value;
        }
    }
}
