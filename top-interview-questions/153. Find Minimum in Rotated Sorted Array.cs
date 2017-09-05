public class Solution {
    public int FindMin(int[] nums) {
        int left = 0, right = nums.Length - 1;
        while (left + 1 < right) {
            int mid = left + (right - left) / 2;
            if (nums[mid] < nums[right]) {
                right = mid;
            } else {
                left = mid;
            }
        }
        if (nums[left] > nums[right]) {
            return nums[right];
        }
        return nums[left];
    }
}