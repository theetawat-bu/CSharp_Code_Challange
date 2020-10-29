using System;

namespace Defanging_an_IP_Address
{
    class Program
    {
        //https://leetcode.com/problems/defanging-an-ip-address
        static void Main(string[] args)
        {
            Console.WriteLine(DefangIPaddr("1.1.1.1"));
        }

        public static string DefangIPaddr(string address)
        {
  
            string[] words = address.Split('.');
            string newIp = "";
            newIp += words[0];
           for(int i = 0; i < words.Length - 1; i++)
            {
                newIp += "[.]"+words[i + 1];
            }
            return newIp;


        }
    }
}
