using System;

namespace Shuffle_the_Array
{
    //https://leetcode.com/problems/shuffle-the-array
    class Program
    {
        static void Main(string[] args)
        {
            int []nums = { 2,5,1,3,4,7 };
            int n = 3;
            int []newarray = Shuffle(nums,n);
            for (int i = 0; i < newarray.Length - 1; i++)
                Console.WriteLine(newarray[i]);
        }

        public static int[] Shuffle(int[] nums, int n)
        {
            int []x = new int[n];
            int [] y = new int[n];

            for (int i = 0; i < n; i++) {
                x[i] = nums[i];
                y[i] = nums[n + i ];

            }

            int[] newarray = new int[nums.Length];
            int countX = 0,countY=0,counter=0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (counter % 2 == 0)
                {
                    newarray[i] = x[countX];
                    countX++;
                }
                else
                {
                    newarray[i] = y[countY];
                    countY++;
                }
                counter++;
                
            }

            return newarray;

        }
    }
}
