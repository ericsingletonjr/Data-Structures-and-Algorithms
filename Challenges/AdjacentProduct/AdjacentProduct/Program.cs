using System;

namespace AdjacentProduct
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[,] dataSet = new int[,] { { 1, 2, 1 }, { 2, 4, 2 }, { 3, 6, 8 }, { 7, 8, 1 } };

            Console.WriteLine(AdjacentProduct(dataSet));
        }

        public static int AdjacentProduct(int[,] dataSet)
        {
            int largestValue = 0, dataSetJ = dataSet.GetLength(0), dataSetI = dataSet.GetLength(1);

            for(int j = 0; j < dataSet.GetLength(0); j++)
            {
                for(int i = 0; i < dataSet.GetLength(1); i++)
                {

                    if ((i + 1) < dataSetI && (j + 1) < dataSetJ)
                    {
                        largestValue = largestValueProduct((dataSet[j, i] * dataSet[j, i + 1]),
                            (dataSet[j, i] * dataSet[j + 1, i]), (
                            dataSet[j, i] * dataSet[j + 1, i + 1]));
                    }
                    if (j == dataSetJ - 1 && i+1 < dataSetI)
                    {
                        largestValue = largestValueProductBottom((dataSet[j, i] * dataSet[j, i + 1]),
                            (dataSet[j, i] * dataSet[j - 1, i+1]));
                    }
                }
            }
            /// <summary>
            /// This method goes throw the array to calculate the product
            /// of adjacent values
            /// </summary>
            /// <param name="forward">input for one step ahead of the current index</param>
            /// <param name="below">input for one step under the current index</param>
            /// <param name="diagonal">input for one step diagonal from the current index</param>
            /// <returns>the largestValue</returns>
            int largestValueProduct(int forward, int below, int diagonal)
            {

                largestValue = forward > largestValue ? forward : largestValue;
                largestValue = below > largestValue ? below : largestValue;
                largestValue = diagonal > largestValue ? diagonal : largestValue;

                return largestValue;
            }
            /// <summary>
            /// This method is to account for the final row in the 2D array
            /// </summary>
            /// <param name="forward">input for one step ahead of the current index</param>
            /// <param name="diagonal">input for one step diagonal from the current index</param>
            /// <returns>largestValue</returns>
            int largestValueProductBottom(int forward, int diagonal)
            {

                largestValue = forward > largestValue ? forward : largestValue;
                largestValue = diagonal > largestValue ? diagonal : largestValue;
                return largestValue;
            }

            return largestValue;
        }
    }
}
