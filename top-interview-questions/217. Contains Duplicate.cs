public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        if (nums == null || nums.Length == 0) return false;
        HashSet<int> set = new HashSet<int>();
        for (int i = 0; i < nums.Length; i++) {
            // return ture when meet duplictes
            if (!set.Add(nums[i])) return true;
        }
        return false;
    }
}