public class Solution {
    public int Rob(int[] nums) {
        if (nums == null || nums.Length == 0) return 0;
        int rob = 0;  // max if rob current house;
        int notRob = 0; // max if not rob current house;
        for (int i = 0; i < nums.Length; i++) {
            int curRob = notRob + nums[i];
            //if not rob ith house, take the max value 
            // of notRob or rob for previous house
            notRob = Math.Max(notRob, rob);
            rob = curRob;
        }
        return Math.Max(rob, notRob);
    }
}