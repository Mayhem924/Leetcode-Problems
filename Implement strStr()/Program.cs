using System;

namespace Implement_strStr__
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"hello - ll -> {StrStr("hello", "ll")}");    // 2
            Console.WriteLine($"aaaa - bba -> {StrStr("aaaa", "bba")}");    // -1
            Console.WriteLine($"'' - '' -> {StrStr("", "")}");              // 0

            Console.ReadLine();
        }

        static int StrStr(string haystack, string needle)
        {
            return haystack.IndexOf(needle);
        }
    }
}
