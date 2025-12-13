using System.Diagnostics;

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
            int Sum = HasDistictWithinWindowSize(window, WindowSize) ? 0: window.Sum();

            MaxSum = Math.Max(MaxSum, Sum);
            End++;

        }

        return MaxSum;
    }

    public bool HasDistictWithinWindowSize(int[] window, int size)
    {
        //int left = 0;
      

        //Dictionary<int, int> Disticts = new Dictionary<int, int>();

        //for (int right = 0; right < window.Length; right++)
        //{
        //    if (Disticts.ContainsKey(window[right]))
        //    {

        //        Disticts[window[right]]++;
        //    }
        //    else
        //    { 
            
        //        Disticts.Add(window[right], 1);
        //    }

        //}
        
        //return Disticts.Keys.Count() < size;
        return window.Distinct().Count() < size;

    }

    public long MessureTimeComplexity(Func<long> func)
    { 
        var watch = Stopwatch.StartNew();
        func();
        return watch.ElapsedMilliseconds;
    }
}
