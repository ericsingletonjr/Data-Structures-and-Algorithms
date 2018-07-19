using System;
using Xunit;
using LeftJoins;
using LeftJoins.Classes;
using System.Collections.Generic;

namespace LeftJoinsTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestIfBothHashMapsAreEmpty()
        {
            HashTable hs1 = new HashTable();
            HashTable hs2 = new HashTable();

            List<List<string>> match = Program.LeftJoin(hs1, hs2);
            Assert.Empty(match);
        }
        [Fact]
        public void TestAllKeysInHashMap1ArePopulated()
        {
            HashTable hs1 = new HashTable();
            HashTable hs2 = new HashTable();

            hs1.Add("at", "e");
            hs1.Add("be", "f");
            hs1.Add("yell", "g");
            hs1.Add("ste", "h");
            hs1.Add("rag", "i");

            List<List<string>> match = Program.LeftJoin(hs1, hs2);
            Assert.Equal(5, match.Count);
        }
        [Fact]
        public void TestThatNoMatchReturnsANull()
        {
            HashTable hs1 = new HashTable();
            HashTable hs2 = new HashTable();

            hs1.Add("at", "e");
            hs2.Add("bo", "hg");

            List<List<string>> match = Program.LeftJoin(hs1, hs2);
            Assert.Contains("NULL", match[0]);
        }
        [Fact]
        public void TestThatHashMap2IsJoinedOnHashMap1()
        {
            HashTable hs1 = new HashTable();
            HashTable hs2 = new HashTable();

            hs1.Add("at", "e");
            hs2.Add("at", "kah");

            List<List<string>> match = Program.LeftJoin(hs1, hs2);
            Assert.Contains("kah", match[0]);
        }
    }
}
