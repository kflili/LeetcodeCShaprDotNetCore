// bit manipulation trick n & (n-1)
public class Solution {
    public bool IsPowerOfTwo(int n) {
        if (n <= 0) return false;  // 2^n is always positive. 
        return (n & (n - 1) )== 0;  // bit manipulation trick
    }
}

// general power problem solution
public class Solution {
    public bool IsPowerOfTwo(int n) {
        if (n > 1) {
            while (n % 2 == 0) n /= 2;
        }
        return n == 1;
    }
}