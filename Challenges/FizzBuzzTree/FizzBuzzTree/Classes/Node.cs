using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzTree.Classes
{
    public class Node
    {
        public string Value { get; set; }
        public Node LeftChild { get; set; }
        public Node RightChild { get; set; }

        public Node(string value)
        {
            Value = value;
        }
    }
}
