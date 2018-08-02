using System;

namespace RadixSortAlgo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] test = new int[] { 5, 20, 10, 80, 105, 284, 60 };
            foreach (int value in test)
            {
                Console.Write(value+" ");
            }
            Console.WriteLine("");
            RadixSort(test, test.Length);
            foreach (int value in test)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine("");
        }
        /// <summary>
        /// Utility Method to help find the max value in our array
        /// This is what determines the amount of passes we need
        /// in our radix sort
        /// </summary>
        /// <param name="array">Array to be sorted</param>
        /// <param name="arrayLength">Array length</param>
        /// <returns>Max value inside of the array</returns>
        public static int MaxValue(int[] array, int arrayLength)
        {
            int max = array[0];
            for (int i = 1; i < arrayLength; i++)
            {
                max = array[i] > max ? array[i] : max;
            }
            return max;
        }
        /// <summary>
        /// Main method that calls the two utility methods
        /// </summary>
        /// <param name="array">Array to be sorted</param>
        /// <param name="arrayLength">Array length</param>
        public static void RadixSort(int[] array, int arrayLength)
        {
            int max = MaxValue(array, arrayLength);

            for (int position = 1; max / position > 0; position *= 10)
            {
                DigitSort(array, arrayLength, position);
            }
        }
        /// <summary>
        /// Method that actually sorts the array. It checks every digit position
        /// based on 10. The amount of times this method is called is based on
        /// the size of the max value in the array. 
        /// </summary>
        /// <param name="array">Array to be sorted</param>
        /// <param name="arrayLength">Array length</param>
        /// <param name="position">The digit position, based on 10</param>
        public static void DigitSort(int[] array, int arrayLength, int position)
        {
            int[] sort = new int[arrayLength];
            int i;
            int[] count = new int[10];

            for (i = 0; i < arrayLength; i++)
            {
                count[(array[i] / position) % 10]++;
            }
            for (i = 1; i < 10; i++)
            {
                count[i] += count[i - 1];
            }
            for (i = arrayLength - 1; i >= 0; i--)
            {
                sort[count[(array[i] / position) % 10] - 1] = array[i];
                count[(array[i] / position) % 10]--;
            }
            for (i = 0; i < arrayLength; i++)
            {
                array[i] = sort[i];
            }
        }
    }
}
