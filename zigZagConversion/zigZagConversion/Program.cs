using System;

namespace zigZagConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //string input = "PAYPALISHIRING";
            string input = "AB";
            int rows = 1;
            Solution x = new Solution();
            Console.WriteLine("Result for string {0} with {1} rows is {2}", input, rows, x.Convert(input, rows));
        }
    }
}
