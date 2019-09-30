using System;
using System.Collections.Generic;
// IMPORT LIBRARY PACKAGES NEEDED BY YOUR PROGRAM
// SOME CLASSES WITHIN A PACKAGE MAY BE RESTRICTED
// DEFINE ANY CLASS AND METHOD NEEDED
// CLASS BEGINS, THIS CLASS IS REQUIRED
public class Solution3
{
    // METHOD SIGNATURE BEGINS, THIS METHOD IS REQUIRED
    public int minimumTime(int numOfParts, int[] parts)
    {
        if (numOfParts < 2 || numOfParts > 1000000)
        {
            return -1;
        }
        else
        {
            int i = 0;
            int time = 0;
            int addition = 0;
            Array.Sort(parts);
            IList<int> list = new List<int>(parts);

            while (i < list.Count)
            {
                if (parts[i] < 1 || parts[i] > 1000000)
                {
                    return -1;

                }
                else if (list.Count == 1)
                {
                    return time;
                }
                else
                {
                    addition = list[i] + list[i + 1];
                    time += addition;
                    list.RemoveAt(i + 1);
                    list.RemoveAt(i);
                    int j = 0;
                    while (j < list.Count && list[j] < addition)
                    {
                        j++;
                    }
                    list.Insert(j, addition);
                }
            }
            return time;
        }
    }


    //// METHOD SIGNATURE ENDS
}