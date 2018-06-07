using System;
using AdjacentProduct;
using Xunit;

namespace AdjacentProductTests
{
    public class UnitTest1
    {
        [Fact]
        public void LargestValue1()
        {
            int[,] dataSet = new int[,] { { 1, 2, 1 }, { 2, 4, 2 }, { 3, 6, 8 }, { 7, 8, 1 } };

            Assert.Equal(64, Program.LargestProduct(dataSet));
        }

        [Fact]
        public void LargestValue2()
        {
            int[,] dataSet = new int[,] { { 6, 3, 5, 9 }, { 2, 8, 4, 6 }, { 3, 8, 2, 1 }, { 6, 7, 3, 5 } };

            Assert.Equal(64, Program.LargestProduct(dataSet));
        }

        [Fact]
        public void LargestValue3()
        {
            int[,] dataSet = new int[,] { {2,5,8,6,7 }, { 10,3,4,9,8}, 
                { 1,6,15,11,2}, { 8,4,6,2,8} ,{ 9,20,2,4,10} };

            Assert.Equal(180, Program.LargestProduct(dataSet));
        }

    }
}
