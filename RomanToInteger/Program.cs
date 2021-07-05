using System;
using System.Collections.Generic;

namespace RomanToInteger
{
    class Program
    {
        static Dictionary<char, int> romans = new Dictionary<char, int>();

        static void Main(string[] args)
        {
            romans.Add('I', 1);
            romans.Add('V', 5);
            romans.Add('X', 10);
            romans.Add('L', 50);
            romans.Add('C', 100);
            romans.Add('D', 500);
            romans.Add('M', 1000);

            Console.WriteLine($"III -> {RomanToInt("III")}");         // 3
            Console.WriteLine($"IX -> {RomanToInt("IX")}");           // 9
            Console.WriteLine($"LVIII -> {RomanToInt("LVIII")}");     // 58
            Console.WriteLine($"MCMXCIV -> {RomanToInt("MCMXCIV")}"); // 1994

            Console.ReadLine();
        }

        static int RomanToInt(string s)
        {
            int sum = 0;
            int prevValue = 0;

            var chars = s.ToCharArray();
            Array.Reverse(chars);

            foreach (var c in chars)
            {
                romans.TryGetValue(c, out int romanValue);

                if (sum == 0)
                {
                    sum += romanValue;
                }
                else
                {
                    if (romanValue >= prevValue)
                    {
                        sum += romanValue;
                    }
                    else
                    {
                        sum -= romanValue;
                    }
                }

                prevValue = romanValue;
            }

            return sum;
        }
    }
}
