// soulution 1
public class Solution {
    public int HammingWeight(uint n) {
        if (n == 0) return 0;
        int result = 0;
        for (int i = 0; i < 32; i++) {
            result += (int)(n & 1);
            n >>= 1;
        }
        return result;
    }
}

// solution 2
public class Solution {
    public int HammingWeight(uint n) {
        int ans = 0;
        int mask = 1;
        for (int i = 0; i < 32; i++) {
            if ((n & mask) != 0) ans++;
            mask <<= 1;
        }
        return ans;
    }
}

// solution 3
public class Solution {
    public int HammingWeight(uint n) {
        int sum = 0;
        while (n != 0) {
            sum++;
            n &= (n - 1);
        }
        return sum;
    }
}