using System;
using System.Collections.Generic;
using System.Linq;

namespace FindIslands
{
    public class Program
    {
        static void Main(string[] args)
        {
            //2 islands
            int[,] adjacency = new int[,]
            {   //A B C D E
                { 0,1,1,0,0 },
                { 1,0,1,0,0 },
                { 1,1,0,0,0 },
                { 0,0,0,0,1 },
                { 0,0,0,1,0 }
            };
            //3 islands
            int[,] adjacency2 = new int[,]
            {   //A B C 
                { 0,0,0 },
                { 0,0,0 },
                { 0,0,0 }
            };
            //4 islands
            int[,] adjacency3 = new int[,]
            {   //A B C D E F G H
                { 0,1,1,0,0,0,0,0 }, //A
                { 1,0,1,0,0,0,0,0 }, //B
                { 1,1,0,0,0,0,0,0 }, //C
                { 0,0,0,0,1,0,0,0 }, //D
                { 0,0,0,1,0,0,0,0 }, //E
                { 0,0,0,0,0,0,1,0 }, //F
                { 0,0,0,0,0,1,0,0 }, //G
                { 0,0,0,0,0,0,0,0 }, //H
            };

            Console.WriteLine(FindIslands(adjacency) + " Island(s)");
            Console.WriteLine("---");
            Console.WriteLine(FindIslands(adjacency2) + " Island(s)");
            Console.WriteLine("---");
            Console.WriteLine(FindIslands(adjacency3) + " Island(s)");
            Console.WriteLine("---");
        }
        /// <summary>
        /// Method that takes in an Adjacency Matrix
        /// and checks how many islands are in a graph
        /// </summary>
        /// <param name="matrix">Adjacency Matrix</param>
        /// <returns>A count of islands</returns>
        public static int FindIslands(int[,] matrix)
        {
            int islandCount = 0;
            List<int> visited = new List<int>();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                bool connected = true;

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 1)
                    {
                        connected = false;
                        if (!visited.Contains(j))
                        {
                            visited.Add(j);
                            islandCount++;
                        }
                        break;
                    }
                }
                if (connected) islandCount++;
                visited.Add(i);
            }
            return islandCount;
        }
    }
}
