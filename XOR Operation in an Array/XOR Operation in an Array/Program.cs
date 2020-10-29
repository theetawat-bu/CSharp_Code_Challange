using System;

namespace XOR_Operation_in_an_Array
{
    class Program
    {
        //https://leetcode.com/problems/xor-operation-in-an-array/
        static void Main(string[] args)
        {
            Console.WriteLine(XorOperation(4, 3));
        }
        public static int XorOperation(int n, int start)
        {
           
            int sum = 0;
           
            for(int i=0;i< n; i++)
            {
                sum = sum ^ start + (2 * i); ;
            }

            return sum;

        }
    }
}
