using System;
using System.Collections.Generic;
using System.Text;

namespace GetEdges.Classes
{
    public class WeightedNode
    {
        public string Value { get; set; }
        public bool Visited { get; set; } = false;
        public Dictionary<WeightedNode, int> Children { get; set; } = new Dictionary<WeightedNode, int>();

        public WeightedNode(string value)
        {
            Value = value;
        }
    }
}
