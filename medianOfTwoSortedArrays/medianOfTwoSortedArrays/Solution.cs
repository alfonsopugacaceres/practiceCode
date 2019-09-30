using System;
using System.Collections.Generic;
using System.Text;

namespace medianOfTwoSortedArrays
{
    public class Solution
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int i = 0;
            int j = 0;
            int solCounter = 0;
            int nums1Len = nums1.Length;
            int nums2Len = nums2.Length;
            int solLen = nums1Len + nums2Len;
            double solSlot = solLen / 2;
            bool singleMedian = (solLen % 2 == 0) ? false : true;
            int[] solutionArray = new int[solLen];



            while(solCounter < solLen && (i < nums1Len || j < nums2Len))
            {
                if(i >= nums1Len)
                {
                    solutionArray[solCounter] = nums2[j++];
                }
                else if (j >= nums2Len)
                {
                    solutionArray[solCounter] = nums1[i++];
                }
                else if(nums1[i] < nums2[j])
                {
                    solutionArray[solCounter] = nums1[i++];
                }
                else if(nums1[i] > nums2[j])
                {
                    solutionArray[solCounter] = nums2[j++];
                }
                else
                {
                    solutionArray[solCounter] = nums1[i++];
                }
                solCounter++;
            }

            double median = (singleMedian) ? solutionArray[(int)solSlot] : (solutionArray[(int) (solSlot - 1)] + solutionArray[(int)(solSlot)]) / 2.0;

            return median;
        }
    }
}
