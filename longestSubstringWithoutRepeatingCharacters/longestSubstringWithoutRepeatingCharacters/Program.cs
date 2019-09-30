using System;

namespace longestSubstringWithoutRepeatingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            SolutionClass x = new SolutionClass();
            string input = "adnnalsdknslgghmldpfvclsffgmgvlsmfdlfgsdj,nbbrpiwslwpdl,";
            string solution = x.LengthOfLongestSubstring(input);
            Console.WriteLine("In the string '{0}' the longest substring without repeating characters is '{1}' and it contains {2} characters",
                input,
                solution, 
                solution.Length);

        }
    }
}
