using System;
using System.Globalization;

namespace Number_of_Good_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://leetcode.com/problems/number-of-good-pairs/
            int[] nums = { 2, 4, 2 };
            Console.WriteLine(NumIdenticalPairs(nums));
        }

        public static int NumIdenticalPairs(int[] nums)
        {
            int sum = 0, counter = 0;
           

            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i; j < nums.Length - 1; j++)
                {
                    if (nums[i] == nums[j+1])
                    {
                        Console.WriteLine("num[" + i + "] = " + nums[i] +" == num["+j+"]");
                        counter++;
                    }
                    Console.WriteLine("num[" + i + "] = " + nums[i] + " != num[" + j + "]");
                }
            }
            return counter;
        }


    }
}