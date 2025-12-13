using System;
using System.Collections.Generic;
using System.Text;

namespace DSAPatterns.SlidingWindow.LongestSubstring;

public class Solution
{

    /// <summary>
    /// Returns the length of the longest substring without repeating characters in the specified string.
    /// </summary>
    /// <param name="s">The string to search for the longest substring without repeating characters. Cannot be null.</param>
    /// <returns>The length of the longest substring of the input string that contains no repeating characters. Returns 0 if the
    /// input string is empty.</returns>
    public int LengthOfLongestSubString(string s)
    {
        if (string.IsNullOrEmpty(s)) return 0;
        int LeftPointer = 0;
        int LongestSoFar = 0;
        Dictionary<char, int> LastVisitedOnPointer = new Dictionary<char, int>();

        for (int RightPointer = 0; RightPointer < s.Length; RightPointer++)
        { 
        
            char currentCharInS = s[RightPointer];
            
            LeftPointer = LastVisitedOnPointer.ContainsKey(currentCharInS) ? 
                Math.Max(LeftPointer, LastVisitedOnPointer[currentCharInS] + 1) : LeftPointer;
            
            LastVisitedOnPointer[currentCharInS] = RightPointer;
            LongestSoFar = Math.Max(LongestSoFar, RightPointer - LeftPointer + 1);

        }

        return LongestSoFar;
    }
}
