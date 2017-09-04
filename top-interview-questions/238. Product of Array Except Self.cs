public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        if (nums == null || nums.Length == 0) return new int[0];
        int n = nums.Length;
        int[] result = new int[n];

        // get the products below the current index
        // result = left: 1, a[0], a[0]*a[1], a[0]*a[1]*a[2]
        int left = 1;
        for (int i = 0; i < n; i++) {
            result[i] = left;
            left *= nums[i];
        }

        // times with the products above the index
        // result = result * right: a[1]*a[2]*a[3], a[2]*a[3], a[3], 1 
        int right = 1;
        for (int i = n - 1; i >= 0; i--) {
            result[i] *= right;
            right *= nums[i];
        }
        return result;
    }
}