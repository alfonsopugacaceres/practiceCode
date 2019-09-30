using System;
using System.Collections.Generic;
using System.Text;

namespace test
{
    public class Solution2
    {
        public int generalizedGCD(int num, int[] arr)
        {
            int current = arr[0];

            for(int i = 1; i < num; i++)
            {
                current = RecurciveGCD(arr[i], current);
            }


            return current;
        }


        public int RecurciveGCD(int x, int y)
        {
            if(y != 0)
            {
                return RecurciveGCD(y, x % y);
            }
            else
            {
                return x;
            }
        }
    }
}
