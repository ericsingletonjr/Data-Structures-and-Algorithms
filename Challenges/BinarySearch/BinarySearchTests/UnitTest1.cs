using System;
using BinarySearch;
using Xunit;

namespace BinarySearchTests
{
    public class UnitTest1
    {
        [Fact]
        //To test if an index is being return
        //if a match is found
        public void CanReturnIndex()
        {
            int[] dataSet = new int[] { 1, 2, 3, 4, 5 };

            Assert.Equal(2 , Program.BinarySearch(dataSet, 3));
        }

        [Fact]
        //To test if no match is found
        //return a -1
        public void CanReturnNoIndex()
        {
            int[] dataSet = new int[] { 1, 2, 3, 4, 5 };

            Assert.Equal(-1, Program.BinarySearch(dataSet, 6));
        }

        [Fact]
        //To test if the the index will be return with
        //a slightly bigger array
        public void CanReturnIndex10()
        {
            int[] dataSet = new int[] { 11, 22, 33, 44, 55, 66, 77, 88, 99, 100 };

            Assert.Equal(9, Program.BinarySearch(dataSet, 100));
        }


    }
}
