public class Solution {
    public bool IsPowerOfThree(int n) {
        if (n <= 0) return false;
        while (n > 1) {
            if (n % 3 != 0) return false;
            n /= 3;
        }
        return true;
    }
}

// concise
public class Solution {
    public bool IsPowerOfThree(int n) {
        if (n > 1) {
            while (n % 3 == 0) n /= 3;
        }
        return n == 1;
    }
}
