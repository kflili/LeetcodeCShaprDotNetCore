using System;
using System.Collections.Generic;
using System.Text;


class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        if (nums == null || nums.Length == 0)
        {
            return 0;
        }
        int slow = 0;
        for (int fast = 0; fast < nums.Length; fast++)
        {
            if (nums[fast] != nums[slow])
            {
                nums[++slow] = nums[fast];
            }
        }
        return slow + 1;
    }
}

