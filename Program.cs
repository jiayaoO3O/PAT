using System;
using System.Collections.Generic;

namespace PAT
{
    class Program
    {
        //1001 A+B Format
        //https://pintia.cn/problem-sets/994805342720868352/problems/994805528788582400
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
        //https://pintia.cn/problem-sets/994805342720868352/problems/994805519074574336
        // static void Main(string[] args)
        // {
        //     //int n = Convert.ToInt32(System.Console.ReadLine());
        //     string s = Console.ReadLine();
        //     int sum = 0;
        //     foreach (var num in s)
        //     {
        //         sum += System.Convert.ToInt32(num) - '0';//这里要注意不能直接用char转换成int,要减去48.
        //     }
        //     //可以用字典,也可以用数组.
        //     // Dictionary<char, string> dict = new Dictionary<char, string>();
        //     // dict.Add('0', "zero");
        //     // dict.Add('1', "one");
        //     // dict.Add('2', "two");
        //     // dict.Add('3', "three");
        //     // dict.Add('4', "four");
        //     // dict.Add('5', "five");
        //     // dict.Add('6', "six");
        //     // dict.Add('7', "seven");
        //     // dict.Add('8', "eight");
        //     // dict.Add('9', "nine");
        //     string[] dict = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        //     s = sum.ToString();
        //     for (int i = 0; i < s.Length; i++)
        //     {
        //         Console.Write(dict[s[i] - '0']);//直接读取s[i]也是char,也要减去48.
        //         if (i != s.Length - 1)
        //         {
        //             Console.Write(" ");
        //         }
        //     }
        //     Console.Read();
        // }

        //1008 Elevator
        //https://pintia.cn/problem-sets/994805342720868352/problems/994805511923286016
        //这一题真尼玛坑,第一个N是指接下来会有的楼层的数量而不是楼层本身.
        //所以3 2 3 1是指有3个楼层,分别是2楼,3楼,1楼.
        static void Main(string[] args)
        {
            string[] tokens = System.Console.ReadLine().Split();
            int result = 0;
            int before = 0;
            int now = 0;
            int[] floors = new int[int.Parse(tokens[0])];
            for (int i = 1; i < tokens.Length; i++)
            {
                floors[i - 1] = int.Parse(tokens[i]);
            }
            for (int i = 0; i < floors.Length; i++)
            {
                now = floors[i];
                if (now > before)
                {
                    result += (now - before) * 6 + 5;
                    before = now;
                }
                else
                {
                    result += (before - now) * 4 + 5;
                    before = now;
                }
            }
            Console.WriteLine(result);
            Console.Read();
        }
        // static void Main(string[] args)
        // {
        //     string[] tokens = System.Console.ReadLine().Split();
        //     Console.Read();
        // }



    }
}
