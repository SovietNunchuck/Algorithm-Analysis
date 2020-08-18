using System;
using System.Collections.Generic;

namespace Chapter_Two_Studio_Bonus
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> testList = new List<int>() { 1, 3, 4, 6, 14, 20, 29, 69 };

            Console.WriteLine("Search for a number:");
            int searchItem = int.Parse(Console.ReadLine());

            Console.WriteLine(BinarySearch(searchItem, testList));
        }

        public static int BinarySearch(int item, List<int> list)
        {
            int lowerBound = 0;
            int upperBound = list.Count - 1;

            while (lowerBound <= upperBound)
            {
                int midValue = (lowerBound + upperBound) / 2;

                if (list[midValue] < item)
                {
                    lowerBound = midValue + 1;
                }
                else if (list[midValue] > item)
                {
                    upperBound = midValue - 1;
                }
                else
                {
                    return midValue;
                }
            }

            return -1;
        }
    }
}
