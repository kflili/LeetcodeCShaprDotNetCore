/*
two pointer and 1 scanner. 
when scanner meet 0, swap with left,
                  1, keep moving scan,
                  2, swap with right
 */

public class Solution {
    public void SortColors(int[] nums) {
        if (nums == null || nums.Length == 0) return;
        int redIndex = 0;
        int blueIndex = nums.Length - 1;
        int i = 0;
        while (i <= blueIndex) {
            if (nums[i] == 0) {
                Swap(nums, redIndex, i);
                redIndex++;
                i++;
            } else if (nums[i] == 1) {
                i++;
            } else {
                Swap(nums, i, blueIndex);
                blueIndex--;
            }
        }
    }
    private void Swap(int[] nums, int i, int j) {
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }
}