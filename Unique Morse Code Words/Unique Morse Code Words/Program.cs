using System;
using System.Collections.Generic;
using System.Linq;

namespace Unique_Morse_Code_Words
{
    class Program
    {
        //https://leetcode.com/problems/unique-morse-code-words/
        static void Main(string[] args)
        {
            string[] words = { "rwjje","aittjje","auyyn","lqtktn","lmjwn" };
            Console.WriteLine(UniqueMorseRepresentations(words));
        }
        public static int UniqueMorseRepresentations(string[] words)
        {
            string[] Morse = {".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-",
                "..-", "...-", ".--", "-..-", "-.--", "--.." };
            string[] code = new string[words.Length];
            char[] alphabet = new char[Morse.Length];
            string concat = "";
            int index = 0,counting=1;
            var d = new Dictionary<string, string>();

            for (char c = 'a'; c <= 'z'; c++) { alphabet[index++] = c; }
            for (index = 0; index < Morse.Length; index++)
            {
                d.Add(alphabet[index].ToString(), Morse[index]);
            }
            index = 0;
            foreach(string word in words)
            {
                concat = "";
                foreach(char c in word)
                {
                    concat += d[c.ToString()];
                }
                code[index++] = concat;
            }

            
            List<string> distinctList = code.Distinct().ToList();
            return distinctList.Count;
        }
    }
}
