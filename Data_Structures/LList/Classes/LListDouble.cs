using System;
using System.Collections.Generic;
using System.Text;

namespace LList.Classes
{
    public class LListDouble
    {
        //Class Fields
        public Node Head { get; set; }

        //Available Contrsuctors
        public LListDouble() { }
        public LListDouble(Node node)
        {
            Head = node;
        }
    }
}
