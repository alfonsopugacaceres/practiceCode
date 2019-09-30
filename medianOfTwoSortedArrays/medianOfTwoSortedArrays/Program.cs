using System;

namespace medianOfTwoSortedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 1, 3, 5, 7, 9 };
            int[] nums2 = { 2, 4, 5, 6, 10 }; 
            //int[] nums1 = { 1, 2 };
            //int[] nums2 = { 3, 4 };
            Solution sol = new Solution();
            Console.WriteLine("The median of array {0} and array {1} is {2}", nums1.ToString(), nums2.ToString(), sol.FindMedianSortedArrays(nums1, nums2));
        }
    }
}
