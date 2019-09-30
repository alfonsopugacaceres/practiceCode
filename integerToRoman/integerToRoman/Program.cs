using System;

namespace integerToRoman
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 40;
            Solution x = new Solution();
            Console.WriteLine("The roman representation of {0} is {1}", input, x.IntToRoman(input));
        }
    }
}