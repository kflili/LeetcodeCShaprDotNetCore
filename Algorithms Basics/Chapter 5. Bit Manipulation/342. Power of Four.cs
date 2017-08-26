public class Solution {
    public bool IsPowerOfFour(int n) {
        if (n > 4) {
            while (n % 4 == 0) n /= 4;
        }
        return n == 1;
    }
}

// without loops
public class Solution {
    public bool IsPowerOfFour(int n) {
        return n > 0 && (n & (n - 1)) == 0 && (n & 0x55555555) != 0;
        //0x55555555 is to get rid of those power of 2 but not power of 4
        //so that the single 1 bit always appears at the odd position 
        // 0x55555555 in binary is 0101_0101_0101_0101_0101_0101_0101_0101
    }
}