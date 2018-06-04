using System;

namespace ArrayReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = new int[] { 23, 55, 321, 1089, -12, 3};
            ArrayReverse(inputArray);
        }
        public static void ArrayReverse(int[] inputArray)
        {

            ReverseArray(inputArray);

            int[] ReverseArray(int[] elements)
            {
                Console.Write("Array Input: [ ");
                foreach (var element in elements) Console.Write(element + " ");
                Console.Write("]\n");
                int[] reverseArray = new int[elements.Length];
                for (int i = 0, j = elements.Length - 1; j > -1; i++, j--)
                {
                    reverseArray[i] = elements[j];
                }
                Console.Write("Reversed Output: [ ");
                foreach (var element in reverseArray) Console.Write(element + " ");
                Console.Write("]");
                Console.ReadLine();
                return reverseArray;
            }
        }
    }
}
