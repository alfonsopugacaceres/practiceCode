using System;
using System.Collections;
using System.Text;
using System.Linq;

namespace equalSubstringsWithinBudget
{
    public class Solution
    {

        public int EqualSubstring(string s, string t, int maxCost)
        {
            if(s == null || s.Length == 0 || s.Length >= 1000000 || t == null || t.Length == 0 || t.Length >= 1000000)
            {
                return 0;
            }

            if(maxCost < 0 || maxCost > 1000000)
            {
                return 0;
            }

            int[] numericalDiff = new int[s.Length];

            int i = 0;
            while (i < s.Length)
            {
                numericalDiff[i] = Math.Abs(s[i] - t[i]);
                i++;
            }

            int [] orderedDiff = numericalDiff.OrderBy(f => f).ToArray();
            int maxNum = 0;
            i = 0;
            while (maxNum + orderedDiff[i] <= maxCost && i < orderedDiff.Length)
            {
                maxNum = maxNum + orderedDiff[i];
                i++;
            }

            return i;
        }
    }
}
