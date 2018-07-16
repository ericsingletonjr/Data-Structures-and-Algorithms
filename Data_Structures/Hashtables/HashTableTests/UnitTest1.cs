using System;
using Xunit;
using Hashtables.Classes;

namespace HashTableTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("Cat")]
        [InlineData("CoolStuff")]
        [InlineData("Banana")]
        [InlineData("Glitch")]
        [InlineData("HashTable")]
        public void AddAKeyValuePairToHashTableAndContainsKey(string key)
        {
            HashTable table = new HashTable();
            table.Add(key, 155);

            Assert.True(table.ContainsKey(key));
        }
        [Theory]
        [InlineData("Cat", 200, 200)]
        [InlineData("CoolStuff", 1024, 1024)]
        [InlineData("Banana", 5,5)]
        [InlineData("Glitch", 24, 24)]
        [InlineData("HashTable", 2048, 2048)]
        public void FindsValueAtGivenKey(string key, int value, int expected)
        {
            HashTable table = new HashTable();
            table.Add(key, value);

            Assert.Equal(expected, table.FindValue(key));
        }
        [Fact]
        public void CanHandleCollision()
        {
            HashTable table = new HashTable();
            table.Add("Cat", 10);
            table.Add("Doe", 100);

            Assert.Equal(163, table.GetHash("Cat"));
            Assert.Equal(163, table.GetHash("Doe"));

            Assert.Equal(10, table.FindValue("Cat"));
        }
        [Fact]
        public void ContainsMultipleKeysInTheEventOfCollision()
        {
            HashTable table = new HashTable();
            table.Add("Cat", 10);
            table.Add("Doe", 100);

            Assert.True(table.ContainsKey("Cat"));
            Assert.True(table.ContainsKey("Doe"));
        }
    }
}
