using System;
using Xunit;
using FizzBuzzTree;
using FizzBuzzTree.Classes;

namespace FizzBuzzTreeTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("3", "Fizz")]
        [InlineData("5", "Buzz")]
        [InlineData("9", "Fizz")]
        [InlineData("10", "Buzz")]
        [InlineData("15", "FizzBuzz")]
        public void CheckFizzBuzzMethod(string value, string expected)
        {
            Assert.Equal(expected, Program.FizzBuzz(value));
        }
        [Theory]
        [InlineData("3.01", "3.01")]
        [InlineData("5.23", "5.23")]
        [InlineData("9.4", "9.4")]
        [InlineData("10.234", "10.234")]
        [InlineData("15.32", "15.32")]
        public void CheckFizzBuzzDouble(string value, string expected)
        {
            Assert.Equal(expected, Program.FizzBuzz(value));
        }
        [Theory]
        [InlineData("banan")]
        [InlineData("fifteen")]
        [InlineData("asdb")]
        [InlineData("awoi")]
        public void NonParseableValues(string value)
        {
            Assert.Equal(value,Program.FizzBuzz(value));
        }
        [Fact]
        public void CheckTreeRoot()
        {
            StringTree stringTree = new StringTree(new Node("3"));
            Program.FizzBuzzTree(stringTree);

            Assert.Equal("Fizz", stringTree.Root.Value);
        }
        [Fact]
        public void CheckTreeRootIfNotFizzBuzz()
        {
            StringTree stringTree = new StringTree(new Node("4"));
            Program.FizzBuzzTree(stringTree);

            Assert.Equal("4", stringTree.Root.Value);
        }
        [Fact]
        public void CheckOtherNodesAlsoChange()
        {
            StringTree stringTree = new StringTree(new Node("4"));
            stringTree.Add(new Node("3"), stringTree.Root);
            stringTree.Add(new Node("7"), stringTree.Root);
            stringTree.Add(new Node("15"), stringTree.Root);
            Program.FizzBuzzTree(stringTree);

            Assert.Equal("FizzBuzz", stringTree.Root.LeftChild.LeftChild.Value);
        }
    }
}
