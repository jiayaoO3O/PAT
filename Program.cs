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

        //1019 General Palindromic Number
        //https://pintia.cn/problem-sets/994805342720868352/problems/994805487143337984
        // public static bool IsPalindromic(int[] input, int index)
        // {
        //     for (int i = 0; i <= index / 2; i++)
        //     {
        //         if (input[i] != input[index - 1 - i])
        //         {
        //             return false;
        //         }
        //     }
        //     return true;
        // }
        // static void Main(string[] args)
        // {
        //     string line = "";
        //     while ((line = System.Console.ReadLine()) != null)
        //     {
        //         string[] tokens = line.Split();
        //         int N = int.Parse(tokens[0]);
        //         int b = int.Parse(tokens[1]);
        //         if (N == 0)
        //         {
        //             Console.WriteLine("Yes");
        //             Console.WriteLine("0");
        //         }
        //         else
        //         {
        //             int[] n = new int[40];
        //             int index = 0;
        //             while (N != 0)
        //             {
        //                 n[index] = N % b;
        //                 N /= b;
        //                 index++;
        //             }
        //             if (IsPalindromic(n, index))
        //             {
        //                 Console.WriteLine("Yes");
        //             }
        //             else
        //             {
        //                 Console.WriteLine("No");
        //             }
        //             for (int i = index - 1; i >= 0; i--)
        //             {
        //                 if (i > 0)
        //                 {
        //                     Console.Write(n[i] + " ");
        //                 }
        //                 else
        //                 {
        //                     Console.WriteLine(n[i]);
        //                 }
        //             }
        //         }
        //     }
        // }

        //1023 Have Fun with Numbers
        //https://pintia.cn/problem-sets/994805342720868352/problems/994805478658260992
        // public static bool Contains(char[] input, char index)
        // {
        //     for (int i = 0; i < input.Length; i++)
        //     {
        //         if (input[i] == index)
        //         {
        //             return true;
        //         }
        //     }
        //     return false;
        // }
        // public static int[] DoubleIntegerArray(int[] num)
        // {
        //     int flag = 0;
        //     int length = num.Length - 1;
        //     while (num[length] != -1)
        //     {
        //         if (num[length] * 2 >= 10)
        //         {
        //             num[length] = num[length] * 2 % 10 + flag;
        //             flag = 1;
        //         }
        //         else
        //         {
        //             num[length] = num[length] * 2 % 10 + flag;
        //             flag = 0;
        //         }
        //         length--;
        //     }
        //     if (flag == 1)
        //     {
        //         num[length] = 1;
        //     }
        //     return num;
        // }
        // public static bool FrequencyIsEmpty(int[] frequency)
        // {
        //     foreach (var fre in frequency)
        //     {
        //         if (fre != 0)
        //         {
        //             return false;
        //         }
        //     }
        //     return true;
        // }
        // public static void Main()
        // {
        //     char[] line = System.Console.ReadLine().ToCharArray();
        //     int[] num = new int[22];
        //     int[] frequency = new int[10];
        //     //用来判断新数字出来的频率和原数字是否一致.如果程序结束后frequency全为0则频率一致.
        //     for (int i = 0; i < num.Length; i++)
        //     {
        //         //将数组置为-1;
        //         num[i] = -1;
        //     }
        //     for (int i = 0; i < line.Length; i++)
        //     {
        //         num[num.Length - line.Length + i] = line[i] - '0';//char转int要-48或者-'0'.
        //         frequency[line[i] - '0']++;//记录对应位置的频率.
        //     }
        //     num = DoubleIntegerArray(num);
        //     for (int i = num.Length - 1; num[i] != -1; i--)
        //     {
        //         if (!Contains(line, (char)(num[i] + 48)))
        //         {
        //             //如果出现了不存在的数字,直接NO
        //             Console.WriteLine("No");
        //             break;
        //         }
        //         frequency[num[i]]--;
        //         if (num[i - 1] == -1)
        //         {
        //             if (FrequencyIsEmpty(frequency))
        //             {
        //                 Console.WriteLine("Yes");
        //             }
        //             else
        //             {
        //                 Console.WriteLine("No");
        //             }
        //         }
        //     }
        //     for (int i = 0; i < num.Length; i++)
        //     {
        //         if (num[i] != -1)
        //         {
        //             Console.Write(num[i]);
        //         }
        //     }
        //     Console.WriteLine();
        // }

        //1027 Colors in Mars
        //https://pintia.cn/problem-sets/994805342720868352/problems/994805470349344768
        // public static string ConvertDecToTarget(int dec, int target, int length)
        // {
        //     char[] result = new char[length];
        //     for (int i = 0; i < length; i++)
        //     {
        //         result[i] = '0';
        //     }
        //     int n = dec;
        //     int index = length - 1;
        //     while (n != 0)
        //     {
        //         if (n % target >= 10)
        //         {
        //             result[index--] = (char)(n % target + 55);
        //         }
        //         else
        //         {
        //             result[index--] = (char)(n % target + 48);
        //         }
        //         n /= target;
        //     }
        //     return new string(result);
        // }
        // public static void Main()
        // {
        //     string[] tokens = System.Console.ReadLine().Split();
        //     int red = int.Parse(tokens[0]);
        //     int green = int.Parse(tokens[1]);
        //     int blue = int.Parse(tokens[2]);
        //     string result = "#";
        //     result += ConvertDecToTarget(red, 13, 2);
        //     result += ConvertDecToTarget(green, 13, 2);
        //     result += ConvertDecToTarget(blue, 13, 2);
        //     Console.WriteLine(result);
        // }

        //1035 Password
        //https://pintia.cn/problem-sets/994805342720868352/problems/994805454989803520
        // public static string ChangePassword(char[] password)
        // {
        //     for (int i = 0; i < password.Length; i++)
        //     {
        //         if (password[i] == '0')
        //         {
        //             password[i] = '%';
        //         }
        //         if (password[i] == '1')
        //         {
        //             password[i] = '@';
        //         }
        //         if (password[i] == 'l')
        //         {
        //             password[i] = 'L';
        //         }
        //         if (password[i] == 'O')
        //         {
        //             password[i] = 'o';
        //         }
        //     }
        //     return new string(password);
        // }
        // public static void Main()
        // {
        //     int userCount = int.Parse(System.Console.ReadLine());
        //     int modifiedCount = 0;
        //     bool[] modifiedInfo = new bool[userCount];
        //     string[] users = new string[userCount];
        //     string[] passwords = new string[userCount];
        //     for (int i = 0; i < userCount; i++)
        //     {
        //         string[] line = System.Console.ReadLine().Split();
        //         users[i] = line[0];
        //         passwords[i] = line[1];
        //     }
        //     for (int i = 0; i < userCount; i++)
        //     {
        //         if (!(ChangePassword(passwords[i].ToCharArray()) == passwords[i]))
        //         {
        //             modifiedInfo[i] = true;
        //             passwords[i] = ChangePassword(passwords[i].ToCharArray());
        //             modifiedCount++;
        //         }
        //     }
        //     if (modifiedCount == 0)
        //     {
        //         if (userCount != 1)
        //         {
        //             Console.WriteLine("There are " + userCount + " accounts and no account is modified");
        //         }
        //         else
        //         {
        //             Console.WriteLine("There is " + userCount + " account and no account is modified");
        //         }
        //     }
        //     else
        //     {
        //         Console.WriteLine(modifiedCount);
        //         for (int i = 0; i < userCount; i++)
        //         {
        //             if (modifiedInfo[i])
        //             {
        //                 Console.WriteLine(users[i] + " " + passwords[i]);
        //             }
        //         }
        //     }
        // }

        //1041 Be Unique
        //https://pintia.cn/problem-sets/994805342720868352/problems/994805444361437184
        // public static void Main()
        // {
        //     string[] tokens = System.Console.ReadLine().Split();
        //     int count = int.Parse(tokens[0]);
        //     int[] numbers = new int[count];
        //     int[] frequency = new int[100000];
        //     for (int i = 0; i < count; i++)
        //     {
        //         numbers[i] = int.Parse(tokens[i + 1]);
        //         frequency[numbers[i]]++;
        //     }
        //     for (int i = 0; i < count; i++)
        //     {
        //         if (frequency[numbers[i]] == 1)
        //         {
        //             Console.WriteLine(numbers[i]);
        //             break;
        //         }
        //         if (i == count - 1)
        //         {
        //             Console.WriteLine("None");
        //         }
        //     }
        // }

        //1042 Shuffling Machine
        //https://pintia.cn/problem-sets/994805342720868352/problems/994805442671132672
        // public static string[] ShufflingMachines(int[] orders, string[] cards)
        // {
        //     string[] result = new string[cards.Length];
        //     for (int i = 0; i < orders.Length; i++)
        //     {
        //         result[orders[i] - 1] = cards[i];
        //     }
        //     return result;
        // }
        // public static void Main()
        // {
        //     int repeatTimes = int.Parse(System.Console.ReadLine());
        //     string[] tokens = System.Console.ReadLine().Split();
        //     int[] orders = new int[tokens.Length];
        //     string[] cards = new string[54];
        //     for (int i = 0; i < 54; i++)
        //     {
        //         orders[i] = int.Parse(tokens[i]);
        //         if (i < 13)
        //         {
        //             cards[i] = "S" + (i + 1).ToString();
        //         }
        //         if (i >= 13 && i < 26)
        //         {
        //             cards[i] = "H" + (i % 13 + 1).ToString();
        //         }
        //         if (i >= 26 && i < 39)
        //         {
        //             cards[i] = "C" + (i % 13 + 1).ToString();
        //         }
        //         if (i >= 39 && i < 52)
        //         {
        //             cards[i] = "D" + (i % 13 + 1).ToString();
        //         }
        //         if (i >= 52)
        //         {
        //             cards[i] = "J" + (i % 13 + 1).ToString();
        //         }
        //     }
        //     for (int i = 0; i < repeatTimes; i++)
        //     {
        //         cards = ShufflingMachines(orders, cards);
        //     }
        //     for (int i = 0; i < cards.Length; i++)
        //     {
        //         if (i != cards.Length - 1)
        //         {
        //             Console.Write(cards[i] + " ");
        //         }
        //         else
        //         {
        //             Console.WriteLine(cards[i]);
        //         }
        //     }
        // }

        //1046 Shortest Distance
        //https://pintia.cn/problem-sets/994805342720868352/problems/994805435700199424
        // public static int GetShortestDistance(int[] nodes, int beginNode, int endNode, int totalDistance)
        // {
        //     int distance = beginNode > endNode ? nodes[beginNode - 1] - nodes[endNode - 1] : nodes[endNode - 1] - nodes[beginNode - 1];
        //     return distance < (totalDistance - distance) ? distance : (totalDistance - distance);
        // }
        // public static void Main()
        // {
        //     string[] tokens = System.Console.ReadLine().Split();
        //     int nodesCount = int.Parse(tokens[0]);
        //     int[] nodes = new int[nodesCount];
        //     int totalDistance = 0;
        //     for (int i = 0; i < nodes.Length; i++)
        //     {
        //         nodes[i] = totalDistance;
        //         totalDistance += int.Parse(tokens[i + 1]);
        //     }
        //     int pairsCount = int.Parse(Console.ReadLine());
        //     for (int i = 0; i < pairsCount; i++)
        //     {
        //         string[] pairs = Console.ReadLine().Split();
        //         Console.WriteLine(GetShortestDistance(nodes, int.Parse(pairs[0]), int.Parse(pairs[1]), totalDistance));
        //     }
        // }

        //1050 String Subtraction
        //https://pintia.cn/problem-sets/994805342720868352/problems/994805429018673152
        // public static void Main()
        // {
        //     string S1 = System.Console.ReadLine();
        //     string S2 = System.Console.ReadLine();
        //     bool[] signals = new bool[127];
        //     foreach (var signal in S2)
        //     {
        //         signals[signal] = true;
        //     }
        //     foreach (var character in S1)
        //     {
        //         if (!signals[character])
        //         {
        //             Console.Write(character);
        //         }
        //     }
        // }

        //1054 The Dominant Color
        //https://pintia.cn/problem-sets/994805342720868352/problems/994805422639136768
        //第一种解法.
        // public static void Main()
        // {
        //     string[] tokens = System.Console.ReadLine().Split();
        //     int column = int.Parse(tokens[0]);
        //     int row = int.Parse(tokens[1]);
        //     int half = (column * row) / 2;
        //     int nowColorCount = 1;
        //     string nowColor = "";
        //     for (int i = 0; i < row; i++)
        //     {
        //         tokens = System.Console.ReadLine().Split();
        //         foreach (var token in tokens)
        //         {
        //             if (token == nowColor)
        //             {
        //                 nowColorCount++;
        //             }
        //             else
        //             {
        //                 nowColorCount--;
        //                 if (nowColorCount == 0)
        //                 {
        //                     nowColor = token;
        //                     nowColorCount = 1;
        //                 }
        //             }
        //         }
        //     }
        //     Console.WriteLine(nowColor);
        // }

        //另一种解法.
        // public static void Main()
        // {
        //     string[] tokens = System.Console.ReadLine().Split();
        //     int column = int.Parse(tokens[0]);
        //     int row = int.Parse(tokens[1]);
        //     int half = (column * row) / 2;
        //     Dictionary<string, int> dict = new Dictionary<string, int>();
        //     for (int i = 0; i < row; i++)
        //     {
        //         tokens = System.Console.ReadLine().Split();
        //         foreach (var token in tokens)
        //         {
        //             if (dict.ContainsKey(token))
        //             {
        //                 dict[token]++;
        //                 if (dict[token] > half)
        //                 {
        //                     Console.WriteLine(token);
        //                     return;
        //                 }
        //             }
        //             else
        //             {
        //                 dict.Add(token, 1);
        //                 if (dict[token] > half)
        //                 {
        //                     Console.WriteLine(token);
        //                     return;
        //                 }
        //             }
        //         }
        //     }
        // }

        //1058 A+B in Hogwarts
        //https://pintia.cn/problem-sets/994805342720868352/problems/994805416519647232
        // public static string HogwartsAddition(string A, string B)
        // {
        //     int[] currencyA = new int[3];
        //     int[] currencyB = new int[3];
        //     int[] result = new int[3];
        //     string[] strA = A.Split('.');
        //     string[] strB = B.Split('.');
        //     int flag = 0;
        //     for (int i = 0; i < strA.Length; i++)
        //     {
        //         currencyA[i] = int.Parse(strA[i]);
        //         currencyB[i] = int.Parse(strB[i]);
        //     }
        //     result[2] = (currencyA[2] + currencyB[2]) % 29;
        //     flag = currencyA[2] + currencyB[2] >= 29 ? 1 : 0;
        //     result[1] = (currencyA[1] + currencyB[1] + flag) % 17;
        //     flag = currencyA[1] + currencyB[1] + flag >= 17 ? 1 : 0;
        //     result[0] = currencyA[0] + currencyB[0] + flag;
        //     return result[0] + "." + result[1] + "." + result[2];
        // }
        // public static void Main()
        // {
        //     string[] tokens = System.Console.ReadLine().Split();
        //     Console.WriteLine(HogwartsAddition(tokens[0], tokens[1]));
        // }

        //1061 Dating
        //https://pintia.cn/problem-sets/994805342720868352/problems/994805411985604608
        // public static void Main()
        // {
        //     string[] tokens = new string[4];
        //     string[] result = { "", "", "" };
        //     int flag = 0;
        //     string[] week = { "MON", "TUE", "WED", "THU", "FRI", "SAT", "SUN" };
        //     for (int i = 0; i < tokens.Length; i++)
        //     {
        //         tokens[i] = System.Console.ReadLine();
        //     }
        //     for (int i = 0; i < tokens[0].Length && i < tokens[1].Length; i++)
        //     {
        //         if (tokens[0][i] == tokens[1][i] && tokens[0][i] >= 'A' && tokens[0][i] <= 'G')
        //         {
        //             result[0] = week[tokens[0][i] - 'A'];
        //             flag = i + 1;
        //             break;
        //         }
        //     }
        //     for (int i = flag; i < tokens[0].Length && i < tokens[1].Length; i++)
        //     {
        //         if (tokens[0][i] == tokens[1][i] && (tokens[0][i] >= '0' && tokens[0][i] <= '9' || tokens[0][i] >= 'A' && tokens[0][i] <= 'N'))
        //         {
        //             result[1] = tokens[0][i] > '9' ? (tokens[0][i] - '7').ToString() : "0" + tokens[0][i];
        //             break;
        //         }
        //     }
        //     for (int i = 0; i < tokens[2].Length && i < tokens[3].Length; i++)
        //     {
        //         if (tokens[2][i] == tokens[3][i] && (tokens[2][i] >= 'A' && tokens[2][i] <= 'Z' || tokens[2][i] >= 'a' && tokens[2][i] <= 'z'))
        //         {
        //             result[2] = i < 10 ? "0" + i : i.ToString();
        //             Console.WriteLine(result[0] + " " + result[1] + ":" + result[2]);
        //             return;
        //         }
        //     }
        // }

        //1065 A+B and C (64bit)
        //https://pintia.cn/problem-sets/994805342720868352/problems/994805406352654336
        // public static void Main()
        // {
        //     int T = int.Parse(Console.ReadLine());
        //     for (int i = 0; i < T; i++)
        //     {
        //         long A, B, C;
        //         string[] tokens = System.Console.ReadLine().Split();
        //         //decimal A, B, C;
        //         // A = decimal.Parse(tokens[0]);
        //         // B = decimal.Parse(tokens[1]);
        //         // C = decimal.Parse(tokens[2]);
        //         // if (A + B > C ? true : false)
        //         // {
        //         //     Console.WriteLine("Case #{0}: true", i + 1);
        //         // }
        //         // else
        //         // {
        //         //     Console.WriteLine("Case #{0}: false", i + 1);
        //         // }
        //         A = long.Parse(tokens[0]);
        //         B = long.Parse(tokens[1]);
        //         C = long.Parse(tokens[2]);
        //         long sum = A + B;
        //         if (A > 0 && B > 0 && sum < 0)
        //         {
        //             Console.WriteLine("Case #{0}: true", i + 1);
        //         }
        //         else
        //         {
        //             if (A < 0 && B < 0 && sum >= 0)
        //             {
        //                 Console.WriteLine("Case #{0}: false", i + 1);
        //             }
        //             else
        //             {
        //                 if (sum > C)
        //                 {
        //                     Console.WriteLine("Case #{0}: true", i + 1);
        //                 }
        //                 else
        //                 {
        //                     Console.WriteLine("Case #{0}: false", i + 1);
        //                 }
        //             }
        //         }
        //     }
        // }

        //1069 The Black Hole of Numbers
        //https://pintia.cn/problem-sets/994805342720868352/problems/994805400954585088
        // public static string Reverse(string input)
        // {
        //     char[] num = input.ToCharArray();
        //     Array.Reverse(num);
        //     return new string(num);
        // }
        // public static string decreasingSort(string input)
        // {
        //     while (input.Length != 4)
        //     {
        //         input += "0";
        //     }
        //     char[] num = input.ToCharArray();
        //     Array.Sort(num);
        //     Array.Reverse(num);
        //     return new string(num);
        // }
        // public static void Main()
        // {
        //     string input = System.Console.ReadLine();
        //     string result = "";
        //     string sortedInput = "";
        //     string reversedInput = "";
        //     while (result != "6174")
        //     {
        //         sortedInput = decreasingSort(input);
        //         reversedInput = Reverse(sortedInput);
        //         result = (int.Parse(sortedInput) - int.Parse(reversedInput)).ToString();
        //         if (sortedInput == reversedInput)
        //         {
        //             Console.WriteLine("{0} - {1} = {2}", sortedInput, reversedInput, "0000");
        //             return;
        //         }
        //         Console.WriteLine("{0} - {1} = {2}", sortedInput, reversedInput, result.Length == 4 ? result : "0" + result);
        //         input = result;
        //     }
        // }

        //1077 Kuchiguse
        //https://pintia.cn/problem-sets/994805342720868352/problems/994805390896644096
        // public static int MaxLengthOfSubstring(string[] inputs)
        // {
        //     int result = 0;
        //     char[] standard = inputs[0].ToCharArray();
        //     char[] str;
        //     Array.Reverse(standard);
        //     for (int i = 0; i < standard.Length; i++)
        //     {
        //         foreach (var input in inputs)
        //         {
        //             str = input.ToCharArray();
        //             Array.Reverse(str);
        //             if (str[i] != standard[i])
        //             {
        //                 return result;
        //             }
        //         }
        //         result++;
        //     }
        //     return result;
        // }
        // public static void Main()
        // {
        //     int count = int.Parse(Console.ReadLine());
        //     string[] inputs = new string[count];
        //     for (int i = 0; i < count; i++)
        //     {
        //         inputs[i] = Console.ReadLine();
        //     }
        //     count = MaxLengthOfSubstring(inputs);
        //     string substring = inputs[0].Substring(inputs[0].Length - count);
        //     Console.WriteLine(count == 0 ? "nai" : substring);
        // }

        //1081 Rational Sum
        //https://pintia.cn/problem-sets/994805342720868352/problems/994805386161274880
        // public static long GetGreatestCommonDivisor(long numerator, long denominator)
        // {
        //     return denominator == 0 ? Math.Abs(numerator) : GetGreatestCommonDivisor(denominator, numerator % denominator);
        //     //辗转相除法的递归形式.
        // }
        // public static long[] GetRationalSum(long[] rationalSum, long[] rationalNumber)
        // {
        //     long greatestCommonDivisor = GetGreatestCommonDivisor(rationalNumber[0], rationalNumber[1]);
        //     rationalNumber[0] = rationalNumber[0] / greatestCommonDivisor;
        //     rationalNumber[1] = rationalNumber[1] / greatestCommonDivisor;
        //     rationalSum[0] = rationalSum[0] * rationalNumber[1] + rationalSum[1] * rationalNumber[0];
        //     rationalSum[1] = rationalSum[1] * rationalNumber[1];
        //     greatestCommonDivisor = GetGreatestCommonDivisor(rationalSum[0], rationalSum[1]);
        //     rationalSum[0] = rationalSum[0] / greatestCommonDivisor;
        //     rationalSum[1] = rationalSum[1] / greatestCommonDivisor;
        //     return rationalSum;
        // }
        // public static void Main()
        // {
        //     Console.ReadLine();
        //     string[] inputs = Console.ReadLine().Split();
        //     long[] rationalSum = new long[2] { 0, 1 };
        //     long[] rationalNumber = new long[2];
        //     long integer = 0;
        //     foreach (var input in inputs)
        //     {
        //         rationalNumber[0] = long.Parse(input.Split('/')[0]);
        //         rationalNumber[1] = long.Parse(input.Split('/')[1]);
        //         rationalSum = GetRationalSum(rationalSum, rationalNumber);
        //     }
        //     integer = rationalSum[0] / rationalSum[1];
        //     rationalSum[0] = rationalSum[0] % rationalSum[1];
        //     if (integer == 0)
        //     {
        //         if (rationalSum[0] == 0)
        //         {
        //             Console.WriteLine("0");
        //         }
        //         else
        //         {
        //             Console.WriteLine("{0}/{1}", rationalSum[0], rationalSum[1]);
        //         }
        //     }
        //     else
        //     {
        //         if (rationalSum[0] == 0)
        //         {
        //             Console.WriteLine(integer);
        //         }
        //         else
        //         {
        //             Console.WriteLine("{0} {1}/{2}", integer, rationalSum[0], rationalSum[1]);
        //         }
        //     }
        // }

        //1084 Broken Keyboard
        //https://pintia.cn/problem-sets/994805342720868352/problems/994805382902300672
        // public static void Main()
        // {
        //     string original = System.Console.ReadLine().ToUpper();
        //     string typedOut = System.Console.ReadLine().ToUpper();
        //     string result = "";
        //     int[] ascii = new int[128];
        //     foreach (var item in original)
        //     {
        //         ascii[item] = 1;
        //     }
        //     foreach (var item in typedOut)
        //     {
        //         if (ascii[item] == 1)
        //         {
        //             ascii[item] = 0;
        //         }
        //     }
        //     foreach (var item in original)
        //     {
        //         if (ascii[item] == 1)
        //         {
        //             result += item;
        //             ascii[item] = 0;
        //         }
        //     }
        //     Console.WriteLine(result);
        // }
        // public static void Main()
        // {
        //     string original = System.Console.ReadLine().ToUpper();
        //     string typedOut = System.Console.ReadLine().ToUpper();
        //     string result = "";
        //     foreach (var item in original)
        //     {
        //         if (!typedOut.Contains(item.ToString()) && !result.Contains(item.ToString()))
        //         {
        //             result += item;
        //         }
        //     }
        //     Console.WriteLine(result);
        // }

        //1092 To Buy or Not to Buy
        //https://pintia.cn/problem-sets/994805342720868352/problems/994805374509498368
        // public static void Main()
        // {
        //     string shopBeads = Console.ReadLine();
        //     string needBeads = Console.ReadLine();
        //     int missingBeads = 0;
        //     int extraBeads = 0;
        //     int[] colors = new int[128];
        //     foreach (var bead in shopBeads)
        //     {
        //         colors[bead]++;
        //     }
        //     foreach (var bead in needBeads)
        //     {
        //         colors[bead]--;
        //     }
        //     foreach (var bead in shopBeads + needBeads)
        //     {
        //         if (colors[bead] > 0)
        //         {
        //             extraBeads += colors[bead];
        //         }
        //         else
        //         {
        //             missingBeads += colors[bead];
        //         }
        //         colors[bead] = 0;
        //     }
        //     if (missingBeads < 0)
        //     {
        //         Console.WriteLine("No {0}", 0 - missingBeads);
        //     }
        //     else
        //     {
        //         Console.WriteLine("Yes {0}", extraBeads);
        //     }
        // }

        //1100 Mars Numbers
        //https://pintia.cn/problem-sets/994805342720868352/problems/
        // public static int translateToEarth(string MarsNumber)
        // {
        //     Dictionary<string, int> lowerDigits = new Dictionary<string, int>() {
        // {"tret",0},{"jan",1},{"feb",2},{"mar",3},{"apr",4},{"may",5},
        // {"jun",6},{"jly",7},{"aug",8},{"sep",9},{"oct",10},{"nov",11},{"dec",12}};
        //     Dictionary<string, int> higherDigit = new Dictionary<string, int>() {
        // {"tam",1},{"hel",2},{"maa",3},{"huh",4},{"tou",5},
        // {"kes",6},{"hei",7},{"elo",8},{"syy",9},{"lok",10},{"mer",11},{"jou",12}};
        //     string[] numbers = MarsNumber.Split();
        //     if (numbers.Length == 1)
        //     {
        //         if (lowerDigits.ContainsKey(numbers[0]))
        //         {
        //             return lowerDigits[numbers[0]];
        //         }
        //         else
        //         {
        //             return higherDigit[numbers[0]] * 13;
        //         }
        //     }
        //     else
        //     {
        //         return higherDigit[numbers[0]] * 13 + lowerDigits[numbers[1]];
        //     }
        // }
        // public static string translateToMars(int EarthNumber)
        // {
        //     if (EarthNumber == 0)
        //     {
        //         return "tret";
        //     }
        //     string[] lowerDigits = { "tret", "jan", "feb", "mar", "apr", "may", "jun", "jly", "aug", "sep", "oct", "nov", "dec" };
        //     string[] higherDigit = { "", "tam", "hel", "maa", "huh", "tou", "kes", "hei", "elo", "syy", "lok", "mer", "jou" };
        //     int[] number = { 0, 0 };
        //     int i = 1;
        //     while (EarthNumber != 0)
        //     {
        //         number[i--] = EarthNumber % 13;
        //         EarthNumber /= 13;
        //     }
        //     if (number[0] == 0)
        //     {
        //         return lowerDigits[number[1]];
        //     }
        //     else
        //     {
        //         if (number[1] == 0)
        //         {
        //             return higherDigit[number[0]];
        //         }
        //         else
        //         {
        //             return higherDigit[number[0]] + " " + lowerDigits[number[1]];
        //         }
        //     }
        // }
        // public static void Main()
        // {
        //     int result;
        //     int count = int.Parse(Console.ReadLine());
        //     while (count-- != 0)
        //     {
        //         string input = Console.ReadLine();
        //         if (int.TryParse(input, out result))
        //         {
        //             Console.WriteLine(translateToMars(result));
        //         }
        //         else
        //         {
        //             Console.WriteLine(translateToEarth(input));
        //         }
        //     }
        // }

        //1108 Finding Average
        //https://pintia.cn/problem-sets/994805342720868352/problems/994805360777347072
        // public static bool IsLegalInput(string input)
        // {
        //     double result = 0;
        //     if (double.TryParse(input, out result))
        //     {
        //         if (result < -1000 || result > 1000)
        //         {
        //             return false;
        //         }
        //         else
        //         {
        //             if (input.IndexOf('.') > 0 && input.ToString().Length - input.ToString().IndexOf('.') > 3)
        //             {
        //                 return false;
        //             }
        //             else
        //             {
        //                 return true;
        //             }
        //         }
        //     }
        //     else
        //     {
        //         return false;
        //     }
        // }
        // public static void Main()
        // {
        //     int count = int.Parse(Console.ReadLine());
        //     int legalCount = 0;
        //     double legalSum = 0;
        //     string[] inputs = Console.ReadLine().Split();
        //     Queue<string> illegalInput = new Queue<string>();
        //     foreach (var input in inputs)
        //     {
        //         if (IsLegalInput(input))
        //         {
        //             legalSum += double.Parse(input);
        //             legalCount++;
        //         }
        //         else
        //         {
        //             illegalInput.Enqueue(input);
        //         }
        //     }
        //     while (illegalInput.Count != 0)
        //     {
        //         Console.WriteLine("ERROR: {0} is not a legal number", illegalInput.Dequeue());
        //     }
        //     if (legalCount == 0)
        //     {
        //         Console.WriteLine("The average of 0 numbers is Undefined");
        //     }
        //     if (legalCount == 1)
        //     {
        //         Console.WriteLine("The average of 1 number is {0}", legalSum.ToString("0.00"));
        //     }
        //     if (legalCount > 1)
        //     {
        //         Console.WriteLine("The average of {0} numbers is {1}", legalCount, (legalSum / legalCount).ToString("0.00"));
        //     }
        // }

        //1112 Stucked Keyboard
        //https://pintia.cn/problem-sets/994805342720868352/problems/994805357933608960
        // public static void Main()
        // {
        //     int repeatedlyTimes = int.Parse(Console.ReadLine());
        //     string str = Console.ReadLine();
        //     int[] characters = new int[128];
        //     char nowKey = str[0];
        //     int nowKeyCount = 0;
        //     string brokenKeys = "";
        //     string originalString = "";
        //     foreach (var character in (str + " "))
        //     {
        //         if (character == nowKey)
        //         {
        //             nowKeyCount++;
        //         }
        //         else
        //         {
        //             if (nowKeyCount % repeatedlyTimes == 0 && characters[nowKey] != -1)
        //             {
        //                 characters[nowKey] = 1;
        //             }
        //             else
        //             {
        //                 characters[nowKey] = -1;
        //             }
        //             nowKey = character;
        //             nowKeyCount = 1;
        //         }
        //     }
        //     for (int i = 0; i < str.Length; i++)
        //     {
        //         if (characters[str[i]] == 1)
        //         {
        //             if (!brokenKeys.Contains(str[i].ToString()))
        //             {
        //                 brokenKeys += str[i];
        //             }
        //             i += repeatedlyTimes - 1;
        //             originalString += str[i];
        //         }
        //         else
        //         {
        //             originalString += str[i];
        //         }
        //     }
        //     Console.WriteLine(brokenKeys);
        //     Console.WriteLine(originalString);
        // }

        //1116 Come on! Let's C
        //https://pintia.cn/problem-sets/994805342720868352/problems/994805355358306304
        public static bool IsPrime(int input)
        {
            if (input <= 1)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(input); i++)
            {
                if (input % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public static void Main()
        {
            Dictionary<string, int> rankList = new Dictionary<string, int>();
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                rankList.Add(Console.ReadLine(), i + 1);
            }
            count = int.Parse(Console.ReadLine());
            string queryID;
            for (int i = 0; i < count; i++)
            {
                queryID = Console.ReadLine();
                if (!rankList.ContainsKey(queryID))
                {
                    Console.WriteLine("{0}: Are you kidding?", queryID);
                }
                else
                {
                    if (rankList[queryID] == -1)
                    {
                        Console.WriteLine("{0}: Checked", queryID);
                        continue;
                    }
                    if (rankList[queryID] == 1)
                    {
                        Console.WriteLine("{0}: Mystery Award", queryID);
                    }
                    else
                    {
                        if (IsPrime(rankList[queryID]))
                        {
                            Console.WriteLine("{0}: Minion", queryID);
                        }
                        else
                        {
                            Console.WriteLine("{0}: Chocolate", queryID);
                        }
                    }
                    rankList[queryID] = -1;
                }
            }
        }
    }
}