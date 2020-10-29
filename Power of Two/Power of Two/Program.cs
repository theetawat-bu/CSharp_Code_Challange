using System;

namespace Power_of_Two
{
    class Program
    {
        //https://leetcode.com/problems/power-of-two/
        static void Main(string[] args)
        {
            Console.WriteLine(IsPowerOfTwo(8));
        }

        public static bool IsPowerOfTwo(int n)
        {
         
            for(int i = 0; i <= Math.Ceiling(Math.Sqrt(n)); i++)
            {
                if (Math.Pow(2, i) == n)
                    return true;
            }
            return false;
          

        }
    }
}
