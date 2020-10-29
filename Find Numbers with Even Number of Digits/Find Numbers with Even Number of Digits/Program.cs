using System;

namespace Find_Numbers_with_Even_Number_of_Digits
{
    class Program
    {
        //https://leetcode.com/problems/find-numbers-with-even-number-of-digits/
        static void Main(string[] args)
        {
            int[] test = { 555, 901, 482, 1771 };
            Console.WriteLine(FindNumbers(test));
        }
        public static int FindNumbers(int[] nums)
        {
            int counting = 0;
           foreach(int i in nums)
            {
                if( i.ToString().Length % 2 == 0)
                {
                    counting++;
                }
            }
            return counting;
        }
    }
}
