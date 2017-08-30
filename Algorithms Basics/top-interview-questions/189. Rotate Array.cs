// use double reverse tech
public class Solution {
    public void Rotate(int[] nums, int k) {
        if (nums == null || nums.Length == 0 || k % nums.Length == 0) return;
        k %= nums.Length;
        Reverse(nums, 0, nums.Length - 1);
        Reverse(nums, 0, k - 1);
        Reverse(nums, k, nums.Length - 1);
    }
    private void Reverse(int[] nums, int start, int end) {
        while (start < end) {
            var temp = nums[start];
            nums[start] = nums[end];
            nums[end] = temp;
            start++;
            end--;
        }
    }
}