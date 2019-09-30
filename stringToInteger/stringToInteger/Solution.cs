using System;
using System.Collections.Generic;
using System.Text;

namespace stringToInteger
{
    public class Solution
    {
        public int MyAtoi(string str)
        {
            if(str == null || str == string.Empty)
            {
                return 0;
            }
            else
            {
                string trimmedString = string.Empty;
                string answer = string.Empty;
                bool positive = true;
                int start = 0;
                trimmedString = str.Trim(' ');
                if(trimmedString.Length == 0)
                {
                    return 0;
                }
                else if(trimmedString[0] == '-')
                {
                    positive = false;
                    start++;
                }
                else if(trimmedString[0] == '+')
                {
                    positive = true;
                    start++;
                }

                while(start < trimmedString.Length)
                {
                    if (!Char.IsDigit(trimmedString[start]))
                    {
                        break;
                    }
                    else
                    {
                        answer += trimmedString[start];
                        start++;
                    }
                }

                if(answer == string.Empty)
                {
                    return 0;
                }
                else
                { 
                    int ret = 0;
                    try
                    {
                        ret = Convert.ToInt32(answer);
                    }
                    catch(OverflowException ex)
                    {
                        return (positive) ? int.MaxValue : int.MinValue;
                    }

                    if (!positive)
                    {
                        ret *= -1;
                    }

                    return ret;
                }

            }
        }
    }
}
