using System.Diagnostics;

namespace DSAPatterns.SlidingWindow.MaximumSumsubarray;

public class Solution
{
    public long MaximumSubarraySum(int[] Numbers, int WindowSize)
    {
        // initial left pointer and right pointer to 0
        // Get the current window sum at the bingining
        // while the right pointer is still within an array length
        // then it sum has not dublicates 
        // then
        // add the value from the array of the right pointer on the sum
        // remove the value from the array of the left ponter on the sum 
        // add it to the max sum 
        // return max sum

       
        
        if(Numbers.Length < WindowSize) return 0;
        int MaxSum = 0;

        int LeftP = 0;
        int StartingRightWindowP = WindowSize - 1;
        int CurrentSum = Numbers[LeftP..StartingRightWindowP].Sum();

        for (int RightP = ++StartingRightWindowP; RightP < Numbers.Length; RightP++)
        { 
  
            CurrentSum -= Numbers[LeftP++];
            CurrentSum += Numbers[RightP];

            MaxSum = Math.Max(CurrentSum, MaxSum);
     
            
        }

        return MaxSum;
    }



    public long MessureTimeComplexity(Func<long> func)
    { 
        var watch = Stopwatch.StartNew();
        func();
        return watch.ElapsedMilliseconds;
    }
}
