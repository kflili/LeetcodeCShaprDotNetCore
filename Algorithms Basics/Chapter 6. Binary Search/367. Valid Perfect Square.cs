// binary search O(log(n))
public class Solution {
    public bool IsPerfectSquare(int num) {
        long start = 0;
        long end = num;
        while (start + 1 < end) {
            long mid = start + (end - start) / 2;
            if (mid * mid == num) {
                return true;
            } else if (mid * mid < num) {
                start = mid;
            } else {
                end = mid;
            }
        }
        if (start * start == num) return true;
        if (end * end == num) return true;
        return false;
    }
}
// Newton Method, almost constant positive O(1)
public class Solution {
    public bool IsPerfectSquare(int num) {
        long x = num;
        while (x * x > num) {
            x = (x + num / x) / 2;
        }
        return x * x == num;
    }
}