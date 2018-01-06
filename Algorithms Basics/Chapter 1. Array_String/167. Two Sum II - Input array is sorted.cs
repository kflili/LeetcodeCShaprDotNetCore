/*
Similar problems:
1. Two Sum
653. Two Sum IV - Input is a BST
 */
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] result = null;
        if (nums == null || nums.Length < 2) {
            return result;
        }
        for (int i = 0, j = nums.Length - 1; i < j;) {
            var sum = nums[i] + nums[j];
            if (sum == target) {
                result = new int[] { i + 1, j + 1 };
                break;
            }
            if (sum < target) {
                i++;
            } else {
                j--;
            }
        }
        return result;
    }
}