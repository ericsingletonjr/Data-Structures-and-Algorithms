using System;
using Xunit;
using FindIslands;

namespace FindIslandsTest
{
    public class UnitTest1
    {
        [Fact]
        public void CanFindIslandsInAdjacencyMatrix()
        {
            int[,] adjacency = new int[,]
            {   //A B C D E
                { 0,1,1,0,0 },
                { 1,0,1,0,0 },
                { 1,1,0,0,0 },
                { 0,0,0,0,1 },
                { 0,0,0,1,0 }
            };

            Assert.Equal(2, Program.FindIslands(adjacency));
        }
        [Fact]
        public void DeterminesOneIslandExistsWithStarfishPattern()
        {
            int[,] adjacency = new int[,]
            {   //A B C D E
                { 0,0,0,0,1 },
                { 0,0,0,0,1 },
                { 0,0,0,0,1 },
                { 0,0,0,0,1 },
                { 1,1,1,1,0 }
            };

            Assert.Equal(1, Program.FindIslands(adjacency));
        }
        [Fact]
        public void FindsAllIslandsIfNoConnectionsExist()
        {
            int[,] adjacency = new int[,]
            {   //A B C D E
                { 0,0,0,0,0 },
                { 0,0,0,0,0 },
                { 0,0,0,0,0 },
                { 0,0,0,0,0 },
                { 0,0,0,0,0 }
            };

            Assert.Equal(5, Program.FindIslands(adjacency));
        }
        [Fact]
        public void FindsAllIslandsIfSelfReferencingExists()
        {
            int[,] adjacency = new int[,]
            {   //A B C D E
                { 1,0,0,0,0 },
                { 0,1,0,0,0 },
                { 0,0,1,0,0 },
                { 0,0,0,1,0 },
                { 0,0,0,0,1 }
            };

            Assert.Equal(5, Program.FindIslands(adjacency));
        }
    }
}
