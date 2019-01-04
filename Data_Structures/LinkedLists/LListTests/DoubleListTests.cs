using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using LList.Classes;

namespace LListTests
{
    public class DoubleListTests
    {
        //------CONSTRUCTOR TESTS------\\
        [Fact]
        public void InstantiateDoubleListWithoutNode()
        {
            LListDouble ll = new LListDouble();
            Assert.Null(ll.Head);
        }
        [Fact]
        public void InstantiateDoubleListWithNode()
        {
            Node first = new Node("first");
            LListDouble ll = new LListDouble(first);
            Assert.Equal(first, ll.Head);
        }
    }
}
