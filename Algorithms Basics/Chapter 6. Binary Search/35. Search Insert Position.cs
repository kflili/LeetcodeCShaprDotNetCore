// keynote: 
// 1. start from boundary checking
// 2. use simple real case to determine the index in the end
public class Solution {
    public int SearchInsert(int[] nums, int target) {
        if (nums == null || nums.Length == 0) {
            return 0;
        }
        int l = 0, r = nums.Length - 1, m;
        while (l + 1 < r) {
            m = l + (r - l) / 2;
            if (nums[m] == target) {
                return m;
            } else if (nums[m] < target) {
                l = m + 1;
            } else {
                r = m - 1;
            }
        }
        if (target <= nums[l]) {
            return l;
        }
        if (target > nums[r]) {
            return r + 1;
        }
        return r;
    }
}