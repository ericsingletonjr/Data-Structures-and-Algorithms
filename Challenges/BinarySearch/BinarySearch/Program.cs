using System;

namespace BinarySearch
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] dataSet = new int[] { 4, 8, 15, 16, 23, 42 };
            int searchKey = 16;

            Console.WriteLine(BinarySearch(dataSet, searchKey));
            Console.ReadLine();
        }
        public static int BinarySearch(int[] dataSet, int searchKey)
        {
            for(int i = 0; i < dataSet.Length; i++)
            {
                if (dataSet[i] == searchKey) return i;
            }
            return -1;
        }
    }
}
