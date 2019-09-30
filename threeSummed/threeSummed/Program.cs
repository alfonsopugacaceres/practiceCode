using System;
using System.Collections.Generic;

namespace threeSummed
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = { -1, 0, 1, 2, -1, -4 };
            Solution x = new Solution();
            IList<IList<int>> res = x.ThreeSum(input);

            foreach(IList<int> list in res)
            {
                foreach(int slot in list)
                {
                    Console.Write("{0},", slot);
                }
                Console.WriteLine("\n");
            }
        }
    }
}
