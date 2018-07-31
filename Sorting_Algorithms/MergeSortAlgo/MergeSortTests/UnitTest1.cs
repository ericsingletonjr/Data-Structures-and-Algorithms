using System;
using Xunit;
using MergeSortAlgo;

namespace MergeSortTests
{
    public class UnitTest1
    {
        [Fact]
        public void MergeSortAlgorithmWorks()
        {
            int[] array = new int[] { 3, 10, 2, 1, 30, 20, 15 };
            int mid = (0 + array.Length - 1) / 2;
            Program.MergeSort(array, 0, array.Length - 1);

            Assert.Equal(1, array[0]);
            Assert.Equal(30, array[array.Length - 1]);
            Assert.Equal(10, array[mid]);
        }

        [Fact]
        public void MergeSortAlgorithmHandlesNegatives()
        {
            int[] array = new int[] { -3, -10, -2, -1, -30, -20, -15 };
            int mid = (0 + array.Length - 1) / 2;
            Program.MergeSort(array, 0, array.Length - 1);

            Assert.Equal(-30, array[0]);
            Assert.Equal(-1, array[array.Length - 1]);
            Assert.Equal(-10, array[mid]);
        }

        [Fact]
        public void MergeSortAlgorithmStillWorksWithoutGivenValues()
        {
            int[] array = new int[8];
            int mid = (0 + array.Length - 1) / 2;
            Program.MergeSort(array, 0, array.Length - 1);

            Assert.Equal(0, array[0]);
            Assert.Equal(0, array[array.Length - 1]);
            Assert.Equal(0, array[mid]);
        }
    }
}
