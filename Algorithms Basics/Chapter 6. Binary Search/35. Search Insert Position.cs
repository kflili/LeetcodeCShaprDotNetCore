public class Solution {
    public int SearchInsert(int[] nums, int target) {
        if (nums == null || nums.Length == 0) return 0;
        int start = 0;
        int end = nums.Length - 1;
        while (start + 1 < end) {
            int mid = start + (end - start) / 2;
            if (nums[mid] == target) {
                return mid;
            } else if (nums[mid] < target) {
                start = mid;
            } else {
                end = mid;
            }
        }
        if (target <= nums[start]) return start;
        if (nums[start] < target && target <= nums[end]) return end;
        return end+1;
    }
}