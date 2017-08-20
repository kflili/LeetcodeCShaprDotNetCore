/*
Similar problems:
1. Two Sum
653. Two Sum IV - Input is a BST
 */
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] res = null;
        if (nums == null || nums.Length == 0) {
            return res;
        }
        for (int i = 0, j = nums.Length - 1; i < j;) {
            var v = nums[i] + nums[j];
            if (v == target) {
                res = new int[] { i + 1, j + 1 };
                break;
            }
            if (v < target) {
                i++;
            } else {
                j--;
            }
        }
        return res;
    }
}