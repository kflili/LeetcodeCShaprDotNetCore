// direct thought
public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        int[] res = new int[2] { -1, -1 };
        if (nums == null || nums.Length == 0) return res;
        int start = FindLeftIndex(nums, target);
        // if starting point not found, then return not found res[]
        if (start == -1) return res;
        int end = FindRightIndex(nums, target);  // no need to check not found again.
        res[0] = start;
        res[1] = end;
        return res;
    }
    private int FindLeftIndex(int[] nums, int target) {
        int left = 0, right = nums.Length - 1;
        while (left + 1 < right) {
            int mid = left + (right - left) / 2;
            if (nums[mid] < target) {
                left = mid;
            } else {
                right = mid;
            }
        }
        if (nums[left] == target) return left;
        if (nums[right] == target) return right;
        return -1;
    }
    private int FindRightIndex(int[] nums, int target) {
        int left = 0, right = nums.Length - 1;
        while (left + 1 < right) {
            int mid = left + (right - left) / 2;
            if (nums[mid] <= target) {
                left = mid;
            } else {
                right = mid;
            }
        }
        if (nums[right] == target) return right;
        if (nums[left] == target) return left;
        return -1;
    }
}