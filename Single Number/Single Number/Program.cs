using System;

namespace Single_Number
{
    class Program
    {
        //https://leetcode.com/problems/single-number/
        static void Main(string[] args)
        {
            int[] nums = { 4,1,2,1,2 };
            Console.WriteLine(SingleNumber(nums));
        }

        public static int SingleNumber(int[] nums)
        {
            int result;
           int index = 0;
           foreach(int i in nums)
            {
                if (i == nums[index])
                    index++;
                else
                    result = i;
            }

            for(int i = 0; i < nums.Length; i++)
            {
                if (i == nums[index])
                    index++;
                else
                    result = i;
            }
            return result;
        }
    }
}
