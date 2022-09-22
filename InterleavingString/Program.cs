namespace InterleavingString;

// 97. Interleaving String
// https://leetcode.com/problems/interleaving-string/

class Program
{
    public static void Main(string[] args)
    {
        var result = InterleavingString("aa", "ab", "aaba");
        var result1 = InterleavingString("aabcc", "dbbca", "aadbbbaccc");

        Console.WriteLine(result); // true
        Console.WriteLine(result1); // false
        
        Console.ReadLine();
    }

    static bool InterleavingString(string s1, string s2, string s3)
    {
        if (s1.Length + s2.Length != s3.Length)
            return false;

        var rows = s1.Length;
        var cols = s2.Length;

        var dp = new bool[rows + 1, cols + 1];
        dp[rows, cols] = true;
        
        for (int i = rows; i >= 0; i--) {
            for (int j = cols; j >= 0; j--) {
                if (i < rows && s3[i + j] == s1[i] && dp[i + 1, j]) {
                    dp[i,j] = true;
                }
                
                if (j < cols && s3[i + j] == s2[j] && dp[i, j + 1]) {
                    dp[i,j] = true;
                }
            }
        }
        
        return dp[0, 0];
    }
}