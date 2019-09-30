using System;
using System.Collections.Generic;
using System.Text;

namespace test
{
    public class Solution
    {
        //METHOD SIGNATURE BEGINS, THIS METHOD IS REQUIRED
        public int[] cellCompete(int[] states, int days)
        {
            int i = 0;
            int[] snapshot = new int[8];
            while (days > 0)
            {
                while (i < states.Length)
                {
                    if (i - 1 < 0)
                    {
                        snapshot[i] = (states[i + 1] == 1) ? 1 : 0;
                    }
                    else if (i + 1 > states.Length - 1)
                    {
                        snapshot[i] = (states[i - 1] == 1) ? 1 : 0;
                    }
                    else
                    {
                        if (states[i + 1] == states[i - 1])
                        {
                            snapshot[i] = 0;
                        }
                        else
                        {
                            snapshot[i] = 1;
                        }
                    }
                    i++;
                }
                for (int j = 0; j < states.Length; j++)
                {
                    states[j] = snapshot[j];
                }
                days--;
                i = 0;
            }
            return states;
        }
        // METHOD SIGNATURE ENDS
    }
}
