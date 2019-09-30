using System;
using System.Collections.Generic;
using System.Text;

namespace threeSummed
{
    public class Solution
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            Array.Sort(nums);
            IList<IList<int>> res = new List<IList<int>>();
            int i = 0;
            int j = 0;
            int z = nums.Length - 1;
            int sum = 0;

            while ( i < nums.Length - 1)
            {
                j = i + 1;
                while(j < z && j < nums.Length && z < nums.Length)
                {
                    if (nums[i] == nums[j] || nums[i] == nums[z] || nums[z] == nums[j])
                        break;
                    sum = nums[i] + nums[j] + nums[z];
                    if(sum < 0)
                    {
                        z++;
                    }
                    else if(sum > 0)
                    {
                        j++;
                    }
                    else
                    {
                        List<int> temp = new List<int>();
                        temp.Add(nums[i]);
                        temp.Add(nums[j]);
                        temp.Add(nums[z]);
                        res.Add(temp);
                    }
                }
                i++;

            }

            return res;
        }

    }
}
