using System;
using Xunit;
using InsertionSortAlgo;

namespace InsertionSortTest
{
    public class UnitTest1
    {
        [Fact]
        public void InsertionSortAlgorithmWorks()
        {
            int[] arr = new int[] { 10, 2, 1 };
            Program.InsertionSort(arr);

            Assert.Equal(1, arr[0]);
            Assert.Equal(2, arr[1]);
            Assert.Equal(10, arr[2]);
        }
        [Fact]
        public void InsertionSortAlgorithmRecursionVersionWorks()
        {
            int[] arr = new int[] { 10, 2, 1 };
            Program.InsertionSortRecursion(arr, arr.Length-1);

            Assert.Equal(1, arr[0]);
            Assert.Equal(2, arr[1]);
            Assert.Equal(10, arr[2]);
        }
        [Fact]
        public void InsertionSortAlgorithmWorksWithNegatives()
        {
            int[] arr = new int[] { 10, 2, 1, -1, -20 };
            Program.InsertionSort(arr);

            Assert.Equal(-20, arr[0]);
            Assert.Equal(-1, arr[1]);
            Assert.Equal(1, arr[2]);
            Assert.Equal(2, arr[3]);
            Assert.Equal(10, arr[4]);
        }
    }
}
