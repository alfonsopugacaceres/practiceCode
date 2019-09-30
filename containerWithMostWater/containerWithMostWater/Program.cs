using System;

namespace containerWithMostWater
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = { 1,1 };
            Solution x = new Solution();
            Console.WriteLine("The max area of the grid is {0}", x.MaxArea(input));
        }
    }
}
