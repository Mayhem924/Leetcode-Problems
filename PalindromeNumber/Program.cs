using System;
using System.Linq;

namespace PalindromeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"121 -> {IsPalindrome(121)}");   // true
            Console.WriteLine($"-121 -> {IsPalindrome(-121)}"); // false
            Console.WriteLine($"-101 -> {IsPalindrome(-101)}"); // false

            Console.ReadLine();
        }

        static bool IsPalindrome(int x)
        {
            var charSpan = x.ToString().ToCharArray().AsSpan();
            charSpan.Reverse();

            return charSpan.SequenceEqual(x.ToString().AsSpan());
        }
    }
}
