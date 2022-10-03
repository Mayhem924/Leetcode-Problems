namespace MinimumTimeToMakeRopeColorful;

// 1578. Minimum Time to Make Rope Colorful
// https://leetcode.com/problems/minimum-time-to-make-rope-colorful/

class Program
{
    public static void Main(string[] args)
    {
        var result = MinCost("abaac", new[] { 1,2,3,4,5 });
        Console.WriteLine(result); // Output: 3
        
        var result1 = MinCost("aabaa", new[] { 1,2,3,4,1 });
        Console.WriteLine(result1); // Output: 2
        
        Console.ReadLine();
    }
    
    public static int MinCost(string colors, int[] neededTime)
    {
        var totalTime = 0;

        var currTotalTime = neededTime[0];
        var currMaxTime = neededTime[0];

        for (int i = 1; i < colors.Length; i++)
        {
            if (colors[i] != colors[i - 1])
            {
                totalTime += currTotalTime - currMaxTime;
                
                currMaxTime = currTotalTime = neededTime[i];
                continue;
            }
            
            currTotalTime += neededTime[i];
            currMaxTime = Math.Max(currMaxTime, neededTime[i]);
        }
        
        totalTime += currTotalTime - currMaxTime;
        return totalTime;
    }
}