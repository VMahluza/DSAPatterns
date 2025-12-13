using System;
using System.Collections.Generic;
using System.Text;

namespace DSAPatterns.SlidingWindow.LongestSubstring;

public class Solution
{
    public int LengthOfLongestSubString(string s)
    { 
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
