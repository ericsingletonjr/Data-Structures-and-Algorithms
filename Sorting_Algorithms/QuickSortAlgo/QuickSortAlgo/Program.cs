using System;

namespace QuickSortAlgo
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] test = new int[] { 50, 20, 30, 60, 70, 40 };
            foreach(int value in test)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine("");
            QuickSort(test, 0, test.Length - 1);
            foreach (int value in test)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine("");

        }
        /// <summary>
        /// Method that takes in an array, leftIndex value and a rightIndex value
        /// and proceeds to recursively call until the array is sorted. This uses the
        /// divide and conquer method
        /// </summary>
        /// <param name="arr">Array to be sorted</param>
        /// <param name="leftIndex">LeftIndex value</param>
        /// <param name="rightIndex">RightIndex value</param>
        public static void QuickSort(int[] arr, int leftIndex, int rightIndex)
        {
            if(leftIndex < rightIndex)
            {
                int pivot = Partition(arr, leftIndex, rightIndex);
                QuickSort(arr, leftIndex, pivot - 1);
                QuickSort(arr, pivot + 1, rightIndex);
            }
        }
        /// <summary>
        /// Method that takes in the array and a left index and a right index
        /// to begin sorting. It will create an index based off of the leftIndex-1
        /// and while iterating through the array, compare values to the pivot.
        /// If they are less than or equal to the pivot, they will swap
        /// places and this process is repeated until it is completed
        /// </summary>
        /// <param name="arr">Array</param>
        /// <param name="leftIndex">Integer for the leftIndex</param>
        /// <param name="rightIndex">Integer for the rightIndex</param>
        /// <returns>An integer that represents our pivot</returns>
        public static int Partition(int[] arr, int leftIndex, int rightIndex)
        {
            int pivot = arr[rightIndex];
            int swapper;
            int i = (leftIndex - 1);

            for(int j = leftIndex; j <= rightIndex-1; j++)
            {
                if(arr[j] <= pivot)
                {
                    i++;
                    swapper = arr[i];
                    arr[i] = arr[j];
                    arr[j] = swapper;
                }
            }
            swapper = arr[i + 1];
            arr[i + 1] = arr[rightIndex];
            arr[rightIndex] = swapper;
            return (i + 1);
        }
    }
}
