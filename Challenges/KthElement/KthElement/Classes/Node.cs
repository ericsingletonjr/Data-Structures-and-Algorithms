using System;
using System.Collections.Generic;
using System.Text;

namespace KthElement.Classes
{
    public class Node
    {
        /// <summary>
        /// Sets the members to accept a value of type
        /// integer and a value of type Node. Next is set to
        /// null by default
        /// </summary>
        public int Value { get; set; }
        public Node Next { get; set; }
        /// <summary>
        /// Here we are setting the value of the node
        /// </summary>
        /// <param name="value">Desired value</param>
        public Node(int value)
        {
            Value = value;
        }
    }
}
