using System;

namespace equalSubstringsWithinBudget
{
    class Program
    {
        static void Main(string[] args)
        {
            string in1 = "krrgw";
            string in2 = "zjxss";
            int cost = 19;
            Solution s = new Solution();
            s.EqualSubstring(in1, in2, cost);
        }
    }
}
