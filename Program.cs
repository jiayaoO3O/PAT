using System;

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
        // static void Main(string[] args)
        // {
        //     string[] tokens = System.Console.ReadLine().Split();
        //     int result = 0;
        //     int before = 0;
        //     int now = 0;
        //     int[] floors = new int[int.Parse(tokens[0])];
        //     for (int i = 1; i < tokens.Length; i++)
        //     {
        //         floors[i - 1] = int.Parse(tokens[i]);
        //     }
        //     for (int i = 0; i < floors.Length; i++)
        //     {
        //         now = floors[i];
        //         if (now > before)
        //         {
        //             result += (now - before) * 6 + 5;
        //             before = now;
        //         }
        //         else
        //         {
        //             result += (before - now) * 4 + 5;
        //             before = now;
        //         }
        //     }
        //     Console.WriteLine(result);
        //     Console.Read();
        // }

        //1011 World Cup Betting
        //https://pintia.cn/problem-sets/994805342720868352/problems/994805504927186944
        // static void Main(string[] args)
        // {
        //     string[] teams1 = System.Console.ReadLine().Split();
        //     string[] teams2 = System.Console.ReadLine().Split();
        //     string[] teams3 = System.Console.ReadLine().Split();
        //     string[] WTL = { "W", "T", "L" };
        //     double[] t1 = new double[teams1.Length];
        //     double[] t2 = new double[teams2.Length];
        //     double[] t3 = new double[teams3.Length];
        //     for (int i = 0; i < t1.Length; i++)
        //     {
        //         t1[i] = double.Parse(teams1[i]);
        //         t2[i] = double.Parse(teams2[i]);
        //         t3[i] = double.Parse(teams3[i]);
        //     }
        //     double max = 0;
        //     int maxindex = 0;
        //     double socre = 1;
        //     for (int i = 0; i < t1.Length; i++)
        //     {
        //         if (t1[i] > max)
        //         {
        //             max = t1[i];
        //             maxindex = i;
        //         }
        //     }
        //     Console.Write(WTL[maxindex] + " ");
        //     socre *= max;
        //     max = 0;
        //     for (int i = 0; i < t2.Length; i++)
        //     {
        //         if (t2[i] > max)
        //         {
        //             max = t2[i];
        //             maxindex = i;
        //         }
        //     }
        //     Console.Write(WTL[maxindex] + " ");
        //     socre *= max;
        //     max = 0;
        //     for (int i = 0; i < t3.Length; i++)
        //     {
        //         if (t3[i] > max)
        //         {
        //             max = t3[i];
        //             maxindex = i;
        //         }
        //     }
        //     Console.Write(WTL[maxindex] + " ");
        //     socre *= max;
        //     socre = socre * 0.65 * 2 - 2;
        //     Console.Write(socre.ToString("0.00"));
        //     Console.Read();
        // }

        //1015 Reversible Primes
        //https://pintia.cn/problem-sets/994805342720868352/problems/994805495863296000
        // public static bool IsPrime(int input)
        // {
        //     if (input <= 1)
        //     {
        //         return false;
        //     }
        //     for (int i = 2; i < input; i++)
        //     {
        //         if (input % i == 0)
        //         {
        //             return false;
        //         }
        //     }
        //     return true;
        // }
        // public static int Reverse(int prime, int radix)
        // {
        //     int n = prime;
        //     int result = 0;
        //     while (n != 0)
        //     {
        //         result = result * radix + (n % radix);
        //         n /= radix;
        //     }
        //     return result;
        // }
        // public static void Main()
        // {
        //     string line;
        //     int N = 0;
        //     int D = 0;
        //     while ((line = System.Console.ReadLine()) != null)
        //     {
        //         string[] tokens = line.Split();
        //         if (int.Parse(tokens[0]) < 0)
        //         {
        //             break;
        //         }
        //         else
        //         {
        //             N = int.Parse(tokens[0]);
        //             D = int.Parse(tokens[1]);
        //             if (!IsPrime(Reverse(N, D)) || !IsPrime(int.Parse(tokens[0])))
        //             {
        //                 Console.WriteLine("No");
        //             }
        //             else
        //             {
        //                 Console.WriteLine("Yes");
        //             }
        //         }
        //     }
        // }
        // public static void Main()
        // {
        //     string line;
        //     while ((line = System.Console.ReadLine()) != null)
        //     {
        //         string[] tokens = line.Split();
        //         if (true)
        //         {
        //             break;
        //         }
        //         else
        //         {
        //         }
        //     }
        // }

        //1019 General Palindromic Number
        //https://pintia.cn/problem-sets/994805342720868352/problems/994805487143337984
        public static bool IsPalindromic(int[] input, int index)
        {
            for (int i = 0; i <= index / 2; i++)
            {
                if (input[i] != input[index - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            string line = "";
            while ((line = System.Console.ReadLine()) != null)
            {
                string[] tokens = line.Split();
                int N = int.Parse(tokens[0]);
                int b = int.Parse(tokens[1]);
                if (N == 0)
                {
                    Console.WriteLine("Yes");
                    Console.WriteLine("0");
                }
                else
                {
                    int[] n = new int[40];
                    int index = 0;
                    while (N != 0)
                    {
                        n[index] = N % b;
                        N /= b;
                        index++;
                    }
                    if (IsPalindromic(n, index))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No");
                    }
                    for (int i = index - 1; i >= 0; i--)
                    {
                        if (i > 0)
                        {
                            Console.Write(n[i] + " ");
                        }
                        else
                        {
                            Console.WriteLine(n[i]);
                        }
                    }
                }
            }
        }
        // public static void Main()
        // {
        //     string line;
        //     while ((line = System.Console.ReadLine()) != null)
        //     {
        //         string[] tokens = line.Split();
        //         if (true)
        //         {
        //             break;
        //         }
        //         else
        //         {
        //         }
        //     }
        // }
    }
}
