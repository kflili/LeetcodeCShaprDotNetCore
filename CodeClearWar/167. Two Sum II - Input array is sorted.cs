/*
Solution tip: 
    Just use two pointers.

 */
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        for (int i = 0, j = nums.Length - 1; i < j;) {
            var sum = nums[i] + nums[j];
            if (sum == target) {
                return new int[] { i + 1, j + 1 };
            }
            if (sum < target) {
                i++;
            } else {
                j--;
            }
        }
        throw new Exception("No two sum solution");
    }
}



/*
Next challenges:
Find the Duplicate Number
Maximum Product of Three Numbers
Maximum Swap
 */