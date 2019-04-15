using System;
using System.Collections.Generic;

namespace PAT
{
    class Program
    {
        //1001 A+B Format
        // static void Main(string[] args)
        // {
        //     string[] input = Console.ReadLine().Split(' ');
        //     int a = Convert.ToInt32(input[0]);
        //     int b = Convert.ToInt32(input[1]);
        //     string s = (a + b).ToString();
        //     for (int i = 0; i < s.Length; i++)
        //     {
        //         Console.Write(s[i]);
        //         if (s[i] == '-')
        //         {
        //             continue;
        //         }
        //         if ((i + 1) % 3 == s.Length % 3 && i != s.Length - 1)
        //         {
        //             Console.Write(",");
        //         }
        //     }
        // }

        //1005 Spell It Right 
        static void Main(string[] args)
        {
            //int n = Convert.ToInt32(System.Console.ReadLine());
            string s = Console.ReadLine();
            int sum = 0;
            foreach (var num in s)
            {
                sum += System.Convert.ToInt32(num) - '0';//这里要注意不能直接用char转换成int,要减去48.
            }
            //可以用字典,也可以用数组.
            // Dictionary<char, string> dict = new Dictionary<char, string>();
            // dict.Add('0', "zero");
            // dict.Add('1', "one");
            // dict.Add('2', "two");
            // dict.Add('3', "three");
            // dict.Add('4', "four");
            // dict.Add('5', "five");
            // dict.Add('6', "six");
            // dict.Add('7', "seven");
            // dict.Add('8', "eight");
            // dict.Add('9', "nine");
            string[] dict = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            s = sum.ToString();
            for (int i = 0; i < s.Length; i++)
            {
                Console.Write(dict[s[i] - '0']);//直接读取s[i]也是char,也要减去48.
                if (i != s.Length - 1)
                {
                    Console.Write(" ");
                }
            }
            Console.Read();
        }
        // static void Main(string[] args)
        // {
        //     int n = Convert.ToInt32(System.Console.ReadLine());
        //     Console.WriteLine();
        // }


    }
}
