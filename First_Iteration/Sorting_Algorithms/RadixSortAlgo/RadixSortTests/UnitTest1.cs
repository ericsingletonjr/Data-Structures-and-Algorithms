using System;
using Xunit;
using RadixSortAlgo;

namespace RadixSortTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanFindMaxValue()
        {
            int[] array = new int[] { 207, 80, 25, 10, 2, 5, 102, 100, 50, 20, 500 };
            Assert.Equal(500, Program.MaxValue(array, array.Length));
        }
        [Fact]
        public void CanPerformRadixSort()
        {
            int[] array = new int[] { 207, 80, 25, 10, 2, 5, 102, 100, 50, 20, 500 };
            Program.RadixSort(array, array.Length);
            Assert.Equal(2, array[0]);
        }
        [Fact]
        public void EmptyArrayDoesntBreak()
        {
            int[] array = new int[5]; 
            Program.RadixSort(array, array.Length);
            Assert.Equal(0, array[array.Length/2]);
        }
    }
}
