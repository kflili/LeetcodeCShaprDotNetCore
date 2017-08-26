public class Solution {
    public bool IsPowerOfTwo(int n) {
        if (n <= 0) return false;  // 2^n is always positive. 
        return (n & (n - 1) )== 0;  // bit manipulation trick
    }
}