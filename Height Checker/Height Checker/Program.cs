using System;
using System.Linq;

namespace Height_Checker
{
    class Program
    {
        // Runtime: 92 ms, faster than 61.79% of C# online submissions for Height Checker.
        //Memory Usage: 25.1 MB, less than 54.82% of C# online submissions for Height Checker.
        //https://leetcode.com/problems/height-checker
        static void Main(string[] args)
        {
            "
            int[] height = { 1, 1, 4, 2, 1, 3 };
            Console.WriteLine(HeightChecker(height));
        }
        public static int HeightChecker(int[] heights)
        {
            int[] unsorted_array = new int [heights.Length];
            for (int i = 0; i < heights.Length; i++)
            {
                unsorted_array[i] = heights[i];
            }

            int counting = 0;
            Array.Sort(unsorted_array);

           for(int i = 0; i < heights.Length; i++)
            {
                if(heights[i] != unsorted_array[i])
                {
                    counting++;
                }
            }
            return counting;

        }
    }
}
