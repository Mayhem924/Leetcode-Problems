using System.Text;

namespace CheckIfTwoStringArraysAreEquivalent;

class Program
{
    public static void Main(string[] args)
    {
        var result = ArrayStringsAreEqual(new[] {"ab", "c"}, new[] {"a", "bc"});
        Console.WriteLine(result); // Output: true
        
        var result2 = ArrayStringsAreEqual(new[] {"a", "cb"}, new[] {"ab", "c"});
        Console.WriteLine(result2); // Output: false
    }
    
    public static bool ArrayStringsAreEqual(string[] word1, string[] word2)
    {
        var word1Str = new StringBuilder();
        var word2Str = new StringBuilder();

        foreach (var word in word1)
        {
            word1Str.Append(word);
        }

        foreach (var word in word2)
        {
            word2Str.Append(word);
        }

        return word1Str.Equals(word2Str);
    }
}