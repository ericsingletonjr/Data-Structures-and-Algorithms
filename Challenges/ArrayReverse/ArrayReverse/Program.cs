using System;

namespace ArrayReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            //Created a test array to test solution
            int[] inputArray = new int[] { 23, 55, 321, 1089, -12, 3};
            ArrayReverse(inputArray);
        }
        public static void ArrayReverse(int[] inputArray)
        {

            reverseArray(inputArray);

            int[] reverseArray(int[] elements)
            {
                //A formatted console log that shows the inputted
                //array before being reverse
                Console.Write("Array Input: [ ");
                foreach (var element in elements) Console.Write(element + " ");
                Console.Write("]\n");

                //This array's length is initialized based off of the inputted
                //array's length to ensure they are the same size
                int[] revArray = new int[elements.Length];

                //We are declaring two counter variables. i is used to step forward with
                //the new revArray and j is used to step from back to front of the inputted
                //data set
                for (int i = 0, j = elements.Length - 1; j > -1; i++, j--)
                {
                    //Assigns the index of the reversed array with
                    //coresponding input array index
                    revArray[i] = elements[j];
                }
                //Formatted console log that shows the reversed array
                //results for comparisons
                Console.Write("Reversed Output: [ ");
                foreach (var element in revArray) Console.Write(element + " ");
                Console.Write("]");
                Console.ReadLine();

                return revArray;
            }
        }
    }
}
