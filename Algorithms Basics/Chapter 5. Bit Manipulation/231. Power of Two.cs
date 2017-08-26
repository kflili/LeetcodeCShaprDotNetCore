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
        if (n <= 0) return false;
        if (n == 1) return true;
        while (n > 1) {
            if (n % 2 == 1) return false;
            n /= 2;
        }
        return true;
    }
}