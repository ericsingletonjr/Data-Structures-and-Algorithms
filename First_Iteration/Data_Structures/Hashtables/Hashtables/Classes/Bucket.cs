using System;
using System.Collections.Generic;
using System.Text;

namespace Hashtables.Classes
{
    public class Bucket
    {
        public string Key { get; set; }
        public int Value { get; set; }
        public Bucket Next { get; set; }

        public Bucket(string key, int value)
        {
            Key = key;
            Value = value;
        }
    }
}
