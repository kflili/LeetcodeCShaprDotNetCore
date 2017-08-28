/*
When fast pointer find non zoro item, the slow pointer
need keep moving until reach zero item, then swap slow
and fast item.
 */

class Solution {
    public void MoveZeroes(int[] nums) {
        if (nums == null || nums.Length == 0) {
            return;
        }
        int slow = 0;
        for (int fast = 0; fast < nums.Length; fast++) {
            if (nums[fast] != 0 && slow < fast) {
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