using System;
using System.Collections.Generic;

namespace ValidParentheses
{
    class Program
    {
        static Dictionary<char, char> brackets = new Dictionary<char, char>();

        static void Main(string[] args)
        {
            brackets.Add('{', '}');
            brackets.Add('(', ')');
            brackets.Add('[', ']');

            Console.WriteLine("()[]{} -> " + IsValid("()[]{}"));            // true
            Console.WriteLine("([)] -> " + IsValid("([)]"));                // false
            Console.WriteLine("(){([])}{} -> " + IsValid("(){([])}{}"));    // true

            Console.ReadLine();
        }

        static bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();

            foreach (var current in s)
            {
                brackets.TryGetValue(current, out char closeBracket);

                if (brackets.ContainsValue(closeBracket))
                {
                    stack.Push(current);
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }

                    if (current != brackets[stack.Pop()])
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }
    }
}
