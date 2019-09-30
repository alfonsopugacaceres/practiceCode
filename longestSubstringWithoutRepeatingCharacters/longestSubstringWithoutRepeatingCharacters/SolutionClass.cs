using System;
using System.Collections.Generic;
using System.Text;

namespace longestSubstringWithoutRepeatingCharacters
{
    public class SolutionClass
    {
        /// <summary>
        /// Sliding window principle. We take a start and an end, adjusting one at a time based on our
        /// hash set to determine if there were any duplicates. If so, we delete at the initial index and 
        /// increment it, moving out window start index forward. If there are no duplicates then we increment
        /// our sliding window's back index forwards increasing the window size.
        /// </summary>
        /// <param name="input"> String that will be analyzed to find largest possible substring</param>
        /// <returns></returns>
        public string LengthOfLongestSubstring(string input)
        {
            if(input == null || input == string.Empty)
            {
                return string.Empty;
            }
            else
            {
                int i = 0;
                int j = 0;
                string currentNonduplicateString = string.Empty;
                string longestSubstring = String.Empty;
                HashSet<char> currentChars = new HashSet<char>();

                while (j < input.Length && i < input.Length)
                {
                    if (currentChars.Contains(input[j]))
                    {
                        if (longestSubstring.Length < currentNonduplicateString.Length)
                        {
                            longestSubstring = new String(currentNonduplicateString);
                        }

                        currentNonduplicateString = string.Empty;
                        currentChars.Remove(input[i]);
                        i++;
                    }
                    else
                    {
                        currentChars.Add(input[j]);
                        currentNonduplicateString += input[j];
                        j++;
                    }
                }

                longestSubstring = ((longestSubstring.Length == 0 && currentNonduplicateString.Length > 0)) ? currentNonduplicateString : longestSubstring;
                return longestSubstring;
            }
        }

    }
}
