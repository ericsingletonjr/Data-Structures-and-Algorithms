using System;
using System.Collections.Generic;
using System.Text;

namespace LList.Classes
{
    public class Node
    {
        //Class Fields
        public Node Next { get; set; }
        public object Value { get; set; }
        //Available Constructors
        public Node(object value)
        {
            Value = value;
        }
    }
}
