/*
For each step, we move pointer with short height inwards, because the area is determined by short height.
The reason is if the pointer meet some higher height, it may increase the are.
*/

public class Solution {
    public int MaxArea(int[] height) {
        int l = 0, r = height.Length - 1;
        int max = 0;
        while (l < r) {
            max = Math.Max(max, Math.Min(height[l], height[r]) * (r - l));
            if (height[l] < height[r]) {
                l++;
            } else {
                r--;
            }
        }
        return max;
    }
}