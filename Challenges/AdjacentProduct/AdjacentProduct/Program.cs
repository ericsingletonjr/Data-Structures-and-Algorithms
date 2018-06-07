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
            int largestValue = 0, currentValue,  dataSetJ = dataSet.GetLength(0), dataSetI = dataSet.GetLength(1);

            for(int j = 0; j < dataSet.GetLength(0); j++)
            {
                for(int i = 0; i < dataSet.GetLength(1); i++)
                {

                    if ((i + 1) < dataSetI && (j + 1) < dataSetJ)
                    {
                        currentValue = dataSet[j, i] * dataSet[j, i + 1];
                        largestValue = currentValue > largestValue ? currentValue : largestValue;
                        currentValue = dataSet[j, i] * dataSet[j + 1, i];
                        largestValue = currentValue > largestValue ? currentValue : largestValue;
                        currentValue = dataSet[j, i] * dataSet[j + 1, i+1];
                        largestValue = currentValue > largestValue ? currentValue : largestValue;
                    }
                    if (j == dataSetJ - 1 && i+1 < dataSetI)
                    {
                        currentValue = dataSet[j, i] * dataSet[j, i + 1];
                        largestValue = currentValue > largestValue ? currentValue : largestValue;
                        currentValue = dataSet[j, i] * dataSet[j - 1, i + 1];
                        largestValue = currentValue > largestValue ? currentValue : largestValue;
                    }
                }
            }           
            return largestValue;
        }
    }
}
