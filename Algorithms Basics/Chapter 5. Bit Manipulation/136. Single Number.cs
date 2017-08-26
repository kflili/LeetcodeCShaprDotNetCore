// ^: the result is true if and only if exactly one of its operands is true.
// 0^0 = 0; 1^1 =0; A^A = 0; 0^1 = 1; 0^A = A; 
public class Solution {
    public int SingleNumber(int[] nums) {
        int ans = 0;
        foreach (int num in nums) {
            ans ^= num;
        }
        return ans;
    }
}