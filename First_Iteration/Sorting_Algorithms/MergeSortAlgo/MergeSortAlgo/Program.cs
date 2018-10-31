using System;

namespace MergeSortAlgo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] test = new int[] { 6, 2, 1, 4, 3, 5 };

            MergeSort(test, 0, test.Length - 1);
            foreach(int value in test)
            {
                Console.WriteLine(value);
            }

        }
        /// <summary>
        /// Method that finds the middle of an array if the leftIndex
        /// is still less than the rightIndex of an array. It then
        /// recursively calls itself until it reaches 1 value, and then begins
        /// to sort and merge the array back with a helper method.
        /// </summary>
        /// <param name="arr1">Array to be sorted</param>
        /// <param name="leftIndex">LeftIndex of array</param>
        /// <param name="rightIndex">RightIndex of array</param>
        public static void MergeSort(int[] arr1, int leftIndex, int rightIndex)
        {
            if (leftIndex < rightIndex)
            {
                int mid = (leftIndex + rightIndex) / 2;
                MergeSort(arr1, leftIndex, mid);
                MergeSort(arr1, mid + 1, rightIndex);
                Merge(arr1, leftIndex, mid, rightIndex);
            }
        }
        /// <summary>
        /// This is a helper method that takes in the pieces of the array and 
        /// creates helper arrays. These arrays are then given the values from the
        /// main array appropriately and sort the values as it "merges" them back
        /// into the array.
        /// </summary>
        /// <param name="arr1">Array to be sorted</param>
        /// <param name="leftIndex">LeftIndex of the Array</param>
        /// <param name="mid">Middle of the Array</param>
        /// <param name="rightIndex">RightIndex of the Array</param>
        public static void Merge(int[] arr1, int leftIndex, int mid, int rightIndex)
        {
            int i, j, k;
            int[] Left = new int[mid - leftIndex + 1], Right = new int[rightIndex - mid];

            //Puting the values from the main array
            //into our sorted array
            for (i = 0; i < Left.Length; i++)
            {
                Left[i] = arr1[leftIndex + i];
            }
            for (j = 0; j < Right.Length; j++)
            {
                Right[j] = arr1[mid + 1 + j];
            }

            i = 0;
            j = 0;
            k = leftIndex;
            //This sorts the  main array with the created
            //worker arrays
            while (i < Left.Length && j < Right.Length)
            {
                if (Left[i] <= Right[j])
                {
                    arr1[k] = Left[i];
                    i++;
                }
                else
                {
                    arr1[k] = Right[j];
                    j++;
                }
                k++;
            }
            //This is to catch any missed values
            //as well as unsorted values so we don't
            //lose any data in the array
            while (i < Left.Length)
            {
                arr1[k] = Left[i];
                i++;
                k++;
            }
            while (j < Right.Length)
            {
                arr1[k] = Right[j];
                j++;
                k++;
            }
        }
    }
}
