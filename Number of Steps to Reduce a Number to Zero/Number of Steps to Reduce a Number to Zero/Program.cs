using System;

namespace Number_of_Steps_to_Reduce_a_Number_to_Zero
{
    //https://leetcode.com/problems/number-of-steps-to-reduce-a-number-to-zero/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NumberOfSteps(0));
        }
        public static int NumberOfSteps(int num)
        {
            if (num == 0)
                return 0;
            int counting = 1;
            while(num != 1)
            {
                if (num % 2 == 0)
                {
                    num /= 2;
                    
                }
                else
                {
                    num -= 1;
                }
                counting++;
            }
            return counting;
        }
    }
}
