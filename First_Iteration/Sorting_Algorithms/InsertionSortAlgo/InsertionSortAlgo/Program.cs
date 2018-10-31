using System;

namespace InsertionSortAlgo
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[]{ 50, 4, 1, 29, 16, 20, 15, 19 };
            Console.WriteLine("Without Recursion");
            foreach (int unsortedValue in array)
            {
                Console.Write($"{unsortedValue} ");
            }
            Console.WriteLine("");
            InsertionSort(array);

            foreach (int sortedValue in array)
            {
                Console.Write($"{sortedValue} ");
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Using recursion");

            array = new int[] { 50, 4, 1, 29, 16, 20, 15, 19 };
            foreach (int unsortedValue in array)
            {
                Console.Write($"{unsortedValue} ");
            }
            Console.WriteLine("");

            InsertionSortRecursion(array, array.Length-1);

            foreach (int sortedValue in array)
            {
                Console.Write($"{sortedValue} ");
            }
            Console.WriteLine("");
            Console.WriteLine("");
        }
        /// <summary>
        /// Method that implements an insertion sort algorithm.
        /// O(n^2) Performance
        /// </summary>
        /// <param name="arr">Array the needs to be sorted</param>
        public static void InsertionSort(int[] arr)
        {
            int i = 1;
            while(i < arr.Length)
            {
                int value = arr[i];
                int j = i - 1;

                while(j >= 0 && arr[j] > value)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = value;
                i++;
            }
        } 
        /// <summary>
        /// Method that implements the Insertion Sort algorithm
        /// but uses recursion
        /// </summary>
        /// <param name="arr">Array to be sorted</param>
        /// <param name="n">Value to create base-case to end recursion loop</param>
        public static void InsertionSortRecursion(int[] arr, int n)
        {
            if(n > 0)
            {
                InsertionSortRecursion(arr, n - 1);
                int value = arr[n];
                int j = n - 1;
                
                while(j >= 0 && arr[j] > value)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = value;
            }
        }
    }
}
