using System;

namespace BinarySearch
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] dataSet = new int[] { 4, 8, 15, 16, 23, 42, 50, 65, 72 };
            int searchKey = 16;

           BinarySearch(dataSet, searchKey);
        }
        public static int BinarySearch(int[] dataSet, int searchKey)
        {
            //Sets minimum and maximum of each half
            int minThreshold = 0;
            int maxThreshold = dataSet.Length - 1;

            while(maxThreshold >= minThreshold)
            {
                //Find the middle of my dataSet
                int middle = (minThreshold + maxThreshold) / 2;

                //Logic to determine if the new half needs to be shifted up
                //Or down in relation to the search key
                if (dataSet[middle] > searchKey) maxThreshold = middle - 1;
                if (dataSet[middle] < searchKey) minThreshold = middle + 1;
                if (dataSet[middle] == searchKey) return middle;
            }
            return -1;
        }
    }
}
