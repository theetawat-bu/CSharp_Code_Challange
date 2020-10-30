using System;

namespace Create_Target_Array_in_the_Given_Order
{
    class Program
    {
        //https://leetcode.com/problems/create-target-array-in-the-given-order/
        static void Main(string[] args)
        {
            int[] nums = { 0, 1, 2, 3, 4 };
            int[] index = { 0, 1, 2, 2, 1 };
            Console.WriteLine(CreateTargetArray(nums, index));
        }

        public static int[] CreateTargetArray(int[] nums, int[] index)
        {
            int[] newArray = new int[nums.Length];
            int temp;
            for(int i = 0; i < nums.Length; i++)
            {
                if(newArray[index[i]] !=0)
                    newArray[index[i]] = nums[i];
                else
                {
                    temp = newArray[index[i]];
                    newArray[index[i]] = temp;
                    temp = nums[i];
                }
                Console.WriteLine("nums " + i + " index " + index[i] + " nums " + nums[i]);
            }

            foreach(int i in newArray)
            {
                Console.Write(i+" ");
            }
            return newArray;
        }
    }
}
