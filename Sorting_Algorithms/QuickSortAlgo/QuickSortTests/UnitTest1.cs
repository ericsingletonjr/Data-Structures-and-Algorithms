using System;
using Xunit;
using QuickSortAlgo;

namespace QuickSortTests
{
    public class UnitTest1
    {
        [Fact]
        public void QuickSortAlgorithmActuallySorts()
        {
            int[] array = new int[] { 10, 50, 20, 30, 20, 70, 20, 40 };
            Program.QuickSort(array, 0, array.Length - 1);

            Assert.Equal(70, array[array.Length - 1]);
        }

        [Fact]
        public void QuickSortAlgorithmSortsNegatives()
        {
            int[] array = new int[] { -10, -50, -20, -30, -20, -70, 20, 40 };
            Program.QuickSort(array, 0, array.Length - 1);

            Assert.Equal(-70, array[0]);
        }

        [Fact]
        public void QuickSortAlgorithmDoesnotBreakWithNoValues()
        {
            int[] array = new int[8];
            Program.QuickSort(array, 0, array.Length - 1);

            Assert.Equal(0, array[array.Length/2]);
        }
    }
}
