// Binary search
public class Solution {
    public int MySqrt(int x) {
        if (x == 0) return 0;
        int left = 1, right = x;
        while (left + 1 < right) {
            int mid = left + (right - left) / 2;
            if (mid == x / mid) {
                return mid;
            } else if (mid > x / mid) {
                right = mid;
            } else {
                left = mid;
            }
        }
        if (right <= x / right) return right;
        return left;
    }
}

// NewTon
public class Solution {
    public int MySqrt(int x) {
        if (x == 0) return 0;
        long r = x;
        while (r * r > x) {
            r = (r + x / r) / 2;
        }
        return (int)r;
    }
}