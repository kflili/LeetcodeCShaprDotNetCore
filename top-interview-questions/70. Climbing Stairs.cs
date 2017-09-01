public class Solution {
    public int ClimbStairs(int n) {
        if (n == 1) return 1;
        if (n == 2) return 2;
        int[] res = new int[n+1];
        res[1] = 1;
        res[2] = 2;
        for (int i = 3; i <= n; i++) {
            res[i] = res[i - 1] + res[i - 2];
        }
        return res[n];
    }
}

// refactor to Fibonacci Number
public class Solution {
    public int ClimbStairs(int n) {
        if (n == 1) {
            return 1;
        }
        int first = 1;
        int second = 2;
        for (int i = 3; i <= n; i++) {
            int third = first + second;
            first = second;
            second = third;
        }
        return second;
    }
}