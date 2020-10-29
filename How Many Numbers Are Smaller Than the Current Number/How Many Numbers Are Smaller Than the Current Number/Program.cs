using System;

namespace How_Many_Numbers_Are_Smaller_Than_the_Current_Number
{
    class Program
    {
        //https://leetcode.com/problems/how-many-numbers-are-smaller-than-the-current-number/
        static void Main(string[] args)
        {
            int[] nums = { 7,7,7,7 };
            int[] get = SmallerNumbersThanCurrent(nums);
            for(int i = 0; i < get.Length; i++)
            {
                Console.WriteLine(get[i]);
            }
        }

        public  static int[] SmallerNumbersThanCurrent(int[] nums)
        {
            int lastnumber;
            int counting = 0;
            int[] result = new int[nums.Length];

            for(int i = 0; i < nums.Length; i++)
            {
                lastnumber = nums[i];
                counting = 0;
                for(int j=0;j<nums.Length;j++)
                {
                    if (lastnumber > nums[j])
                    {
                     
                        counting++;
                    }

                    result[i] = counting;
                }
            }
            return result;

        }
    }
}
