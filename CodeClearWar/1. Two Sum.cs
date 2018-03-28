public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] result = null;
        if (nums == null || nums.Length < 2) {
            return result;
        }
        var dict = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++) {
            var cur = nums[i];
            var completement = target - cur;
            if (dict.ContainsKey(completement)) {
                result = new int[] { dict[completement], i };
                break;
            }
            if (!dict.ContainsKey(cur)) {
                dict[cur] = i;
            }
        }
        return result;
    }
}