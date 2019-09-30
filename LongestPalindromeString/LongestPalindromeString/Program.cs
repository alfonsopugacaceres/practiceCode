using System;

namespace LongestPalindromeString
{
    class Program
    {
        static void Main(string[] args)
        {
            SolutionClass x = new SolutionClass();
            string sample1 = "racecar";
            string sample2 = "astronaut";
            string input = "nothingaboutthisisapalindromebutracecarnothingaboutthisisapalindrome";

            Console.WriteLine("Is {0} a palindrome? {1}", sample1, (x.IsPalindrome(sample1.ToCharArray())) ? "Yes" : "No");
            Console.WriteLine("Is {0} a palindrome? {1}", sample2, (x.IsPalindrome(sample2.ToCharArray())) ? "Yes" : "No");


            Console.WriteLine("Finding the largest palindrom in '{0}' which is {1}", input, x.FindLongestPalindrome(input));

        }
    }
}
