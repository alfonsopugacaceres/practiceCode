using System;
using System.Collections.Generic;
using System.Text;

namespace zigZagConversion
{
    public class Solution
    {
        public string Convert(string s, int numRows)
        {
            if(s == null || s == string.Empty || numRows <= 0)
            {
                return string.Empty;
            }
            else
            {
                int sLen = s.Length;
                string answer = String.Empty;
                int i = 0;
                bool returnToOrigin = false;
                int xAxis = 0;
                int yAxis = 0;
                IList<String> rows = new List<string>();
                for(int jj = 0; jj < Math.Min(sLen, numRows); jj++)
                {
                    rows.Add(new string(String.Empty));
                }


                while (i < sLen)
                {
                    rows[xAxis] += s[i];
                    i++;
                    if(numRows == 1)
                    {
                        yAxis++;
                    }
                    else if (xAxis < numRows - 1 && !returnToOrigin)
                    {
                        xAxis++;
                    }
                    else if (xAxis == numRows - 1)
                    {
                        xAxis--;
                        yAxis++;
                        returnToOrigin = true;
                    }
                    else if (xAxis == 0)
                    {
                        xAxis++;
                        returnToOrigin = false;
                    }
                    else
                    {
                        xAxis--;
                        yAxis++;
                    }
                }

                for(int ii = 0; ii < rows.Count; ii++)
                {
                    answer += rows[ii];
                }

                return answer;
            }
        }


    }
}
