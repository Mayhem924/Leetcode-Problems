namespace SumOfEvenNumbersAfterQueries;

// 985. Sum of Even Numbers After Queries
// https://leetcode.com/problems/sum-of-even-numbers-after-queries/

class Program
{
    public static void Main(string[] args)
    {
        var nums = new[] { 1, 2, 3, 4 };
        var queries = new[] { new[] { 1, 0 }, new[] { -3, 1 }, new[] { -4, 0 }, new[] { 2, 3 } };

        var result = SumEvenAfterQueries(nums, queries); // result: [8,6,2,4]
        
        Console.ReadLine();
    }

    static int[] SumEvenAfterQueries(int[] nums, int[][] queries)
    {
        var index = 0;
        var result = new int[nums.Length];
        
        var evenResult = nums.Where(x => x % 2 == 0).Sum();
        
        foreach (var item in queries)
        {
            var originalNumber = nums[item[1]];
            var newValue = nums[item[1]] += item[0];

            if (newValue % 2 == 0)
            {
                evenResult += originalNumber % 2 == 0
                    ? item[0]
                    : newValue;
            }
            else
            {
                if (originalNumber % 2 == 0)
                    evenResult -= originalNumber;
            }

            result[index++] = evenResult;
        }

        return result;
    }
}