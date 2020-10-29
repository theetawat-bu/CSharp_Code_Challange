using System;

namespace Shuffle_String
{
    class Program
    {
        //https://leetcode.com/problems/shuffle-string/
        static void Main(string[] args)
        {
            string s  = "aaiougrt";
            int[] indices = {4,0,2,6,7,3,1,5};
            Console.WriteLine(RestoreString(s, indices));
        }

        public static string RestoreString(string s, int[] indices)
        {
            string[] pair = new string[s.Length];
            string result = "";
            int index = 0;
            foreach (int i in indices){
                pair[i] = s[index].ToString();
                index++;
                
            }
            foreach(string c in pair)
            {
                result += c;
            }
            
            
            
            return result;
        }
    }
}
