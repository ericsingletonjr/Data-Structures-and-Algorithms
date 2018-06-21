using System;
using System.Collections.Generic;
using System.Text;

namespace MultiBracketValidation.Classes
{
    public class Node
    {
        public char Value { get; set; }
        public Node Next { get; set; }

        public Node(char value)
        {
            Value = value;
        }
    }
}
