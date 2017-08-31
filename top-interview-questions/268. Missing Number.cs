// XOR
public class Solution {
    public int MissingNumber(int[] nums) {
        int res = nums.Length;
        for (int i = 0; i < nums.Length; i++) {
            res ^= nums[i] ^ i;
        }
        return res;
    }
}