using System;
using System.Collections.Generic;
using System.Text;

namespace containerWithMostWater
{
    public class Solution
    {
        public int MaxArea(int[] height)
        {
            int i = 0;
            int left = 0;
            int right = height.Length - 1;
            int width = height.Length - 1;
            int currentArea = 0;
            int maxArea = 0;


            while (left < right && right > left)
            {
                if((height[left] < height[right]))
                {
                    currentArea = height[left] * width;
                    left++;
                }
                else
                {
                    currentArea = height[right]* width;
                    right--;
                }

                if(currentArea > maxArea)
                {
                    maxArea = currentArea;
                }

                width--;
            }

            return maxArea;
        }
    }
}
