using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LongestPalindromeString
{
    public class SolutionClass
    {

        public bool IsPalindrome(char[] original)
        {
            char[] reverse = new char[original.Length];
            original.CopyTo(reverse, 0);
            Array.Reverse(reverse);
            return original.SequenceEqual(reverse);
        }

        public string FindLongestPalindrome(string input)
        {
            char[] inputChars = input.ToCharArray();
            if(input == null || input.Length <= 0 || input.Length > 1000)
            {
                return string.Empty;
            }
            else if(IsPalindrome(inputChars))
            {
                return input;
            }
            else
            {
                int j = 1;
                string largestPalindrome = string.Empty;
                char[] target = null;
                while (j < input.Length)
                {
                    for (int i = 0; i < input.Length; i++)
                    {
                        if (i + j > input.Length)
                            break;

                        target = input.Substring(i, j).ToCharArray();

                        if (IsPalindrome(target) && target.Length > largestPalindrome.Length)
                        {
                            largestPalindrome = new String(target);
                        }
                    }
                    j++;
                }
                return largestPalindrome;
            }
        }
    }
}
