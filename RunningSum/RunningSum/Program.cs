using System;
using System.Runtime.CompilerServices;

namespace RunningSum
{
    class Program
    {
        //https://leetcode.com/problems/running-sum-of-1d-array
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4 };
            int[] result = RunningSum(nums);
            


        }

        public static int[] RunningSum(int[] nums)
        {
            int counting = nums.Length;
            int[] sum = new int[counting];
            sum[0] = nums[0];

            for (int i = 0; i < counting - 1; i++)
            {
                sum[i + 1] = sum[i] + nums[i + 1];

            }
            return sum;
        }
    }
}
