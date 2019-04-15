using System;
using System.Collections.Generic;

namespace PAT
{
    class Program
    {
        //1001 A+B Format
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int a = Convert.ToInt32(input[0]);
            int b = Convert.ToInt32(input[1]);
            string s = (a + b).ToString();
            for (int i = 0; i < s.Length; i++)
            {
                Console.Write(s[i]);
                if (s[i] == '-')
                {
                    continue;
                }
                if ((i + 1) % 3 == s.Length % 3 && i != s.Length - 1)
                {
                    Console.Write(",");
                }
            }
        }
        // static void Main(string[] args)
        // {
        //     int n = Convert.ToInt32(System.Console.ReadLine());
        //     Console.WriteLine();
        // }

    }
}
