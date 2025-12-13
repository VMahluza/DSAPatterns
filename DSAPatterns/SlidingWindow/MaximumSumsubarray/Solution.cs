namespace DSAPatterns.SlidingWindow.MaximumSumsubarray;

public class Solution
{
    public long MaximumSubarraySum(int[] Numbers, int WindowSize)
    {
        if(Numbers.Length < WindowSize) return 0;

        int End = WindowSize;
        int MaxSum = 0;

        for (int Start = 0; Start < Numbers.Length; Start++ )
        {

            if (End > Numbers.Length) break;

            int[] window =  Numbers[Start..End];

            // Window Count can be Optimized
            int Sum = HasDistictWithinWindowSile(window, WindowSize) ? 0: window.Sum();

            MaxSum = Math.Max(MaxSum, Sum);
            End++;

        }

        return MaxSum;
    }

    public bool HasDistictWithinWindowSile(int[] window, int size)
    {

        return window.Distinct().Count() < size;
    }

    public long MessureTimeComplexity()
    { 
    

        
    }
}
