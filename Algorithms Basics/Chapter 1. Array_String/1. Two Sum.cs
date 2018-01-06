public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] result = null;
        if (nums == null || nums.Length < 2) {
            return result;
        }
        var dict = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++) {
            var cur = nums[i];
            var complement = target - cur;
            if (dict.ContainsKey(complement)) {
                result = new int[] { dict[complement], i };
                break;
            }
            // If using dict.Add(cur, i) will get exception when value cur already exists in dict.
            dict[cur] = i;
        }
        return result;
    }
}