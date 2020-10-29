using System;

namespace Jewels_and_Stones
{
    class Program
    {
        //https://leetcode.com/problems/jewels-and-stones
        static void Main(string[] args)
        {
            Console.WriteLine(NumJewelsInStones("z", "ZZ"));
        }

        public static int NumJewelsInStones(string J, string S)
        {
            int counting = 0;

            foreach(char j in J)
            {
                foreach(char s in S)
                {
                    if (s.Equals(j))
                        counting++;
                }
            }

            return counting;
        }
    }
}
