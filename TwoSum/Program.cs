using System;
using System.Linq;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var result1 = TwoSum(new int[] { 2, 7, 11, 15 }, 9); // [ 0, 1 ]
            var result2 = TwoSum(new int[] { 3, 3 }, 6);         // [ 0, 1 ]
            var result3 = TwoSum(new int[] { 3, 2, 4 }, 6);      // [ 1, 2 ]
        }

        static int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                var value = nums[i];

                for (int y = i + 1; y < nums.Length; y++)
                {
                    var result = value + nums[y];

                    if (result == target)
                    {
                        return new int[] { i, y };
                    }
                }
            }

            return null;
        }
    }
}
