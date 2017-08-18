public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] result = null;
        if (nums == null || nums.Length < 2) {
            return result;
        }
        var dict = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++) {
            int complement = target - nums[i];
            if (dict.ContainsKey(complement)) {
                result = new int[] { dict[complement], i };
                break;
            }
            dict[nums[i]] = i;
        }
        return result;
    }
}