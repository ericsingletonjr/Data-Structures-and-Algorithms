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
            int[] dataSet = new int[] { 1, 2, 3, 4, 5, 6};

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

        [Fact]
        //To test a large array size
        public void CanReturnIndex100()
        {
            int[] dataSet = new int[] {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
                11,12,13,14,15,16,17,18,19,20,
                21,22,23,24,25,26,27,28,29,30,
                31,32,33,34,35,36,37,38,39,40,
                41,42,43,44,45,46,47,48,49,50,
                51,52,53,54,55,56,57,58,59,60,
                61,62,63,64,65,66,67,68,69,70,
                71,72,73,74,75,76,77,78,79,80,
                81,82,83,84,85,86,87,88,89,90,
                91,92,93,94,95,96,97,98,99,100,
            };

            Assert.Equal(87, Program.BinarySearch(dataSet, 88));
        }

    }
}
