using System;
using System.Collections.Generic;
using System.Text;

namespace PriorityQueue.Classes
{
    public class Node
    {
        public int Priority { get; set; }
        public int Value { get; set; }
        public Node Next { get; set; }

        public Node(int value, int priority)
        {
            Value = value;
            Priority = priority;
        }
    }
}
