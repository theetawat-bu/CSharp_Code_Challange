using System;

namespace Subtract_the_Product_and_Sum_of_Digits_of_an_Integer
{
    class Program
    {
        //https://leetcode.com/problems/subtract-the-product-and-sum-of-digits-of-an-integer/
        static void Main(string[] args)
        {
            Console.WriteLine(SubtractProductAndSum(4421));
        }
        public static int SubtractProductAndSum(int n)
        {
            int result,sum=0,product=1;
            int temp;

            while (n!=0)
            {
                temp = n % 10;
                sum += temp;
                product *= temp;
                n /= 10;
            }
            result = product- sum;

            return result;
        }
    }
}
