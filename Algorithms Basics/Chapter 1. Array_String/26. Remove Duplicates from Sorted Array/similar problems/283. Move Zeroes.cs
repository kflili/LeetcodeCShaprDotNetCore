class Solution {
    public void MoveZeroes(int[] nums) {
        if (nums == null || nums.Length == 0) {
            return;
        }
        int slow = 0;
        for (int fast = 0; fast < nums.Length; fast++) {
            if (nums[fast] != 0 && fast != slow) {
                while (slow < fast && nums[slow] != 0) {
                    slow++;
                }
                if (nums[slow] == 0) {
                    nums[slow] = nums[fast];
                    nums[fast] = 0;
                    slow++;
                }
            }
        }
    }
}