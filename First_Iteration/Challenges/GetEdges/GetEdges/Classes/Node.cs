using System;
using System.Collections.Generic;
using System.Text;

namespace GetEdges.Classes
{
    public class Node
    {
        public int Value { get; set; }
        public bool Visited { get; set; } = false;
        public List<Node> Children { get; set; } = new List<Node>();

        public Node(int value)
        {
            Value = value;
        }
    }
}
