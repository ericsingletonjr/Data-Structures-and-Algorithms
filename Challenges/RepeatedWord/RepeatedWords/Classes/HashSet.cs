using System;
using System.Collections.Generic;
using System.Text;

namespace RepeatedWords.Classes
{
    public class HashSet : HashTable
    {
        public HashSet()
        {
            Table = new Bucket[1024];
        }
        /// <summary>
        /// Method that is overriden from the derived class
        /// HashTable to prevent collisions being possible. Will throw
        /// and exception if the index is already assigned a bucket
        /// </summary>
        /// <param name="key">Key</param>
        /// <param name="value">Value</param>
        public override void Add(string key, int value)
        {
            Bucket bucket = new Bucket(key, value);
            int hash = GetHash(key);
            if (ContainsKey(key))
            {
                throw new Exception(message: "This key already exists");
            }
            if (Table[hash] != null)
            {
                throw new Exception();
            }
            Table[hash] = bucket;
        }
    }
}
