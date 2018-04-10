
public class Solution {
    public int Reverse(int x) {
        int res = 0;
        while (x != 0) {
            if (Math.Abs(res) > int.MaxValue / 10) return 0; // check before res * 10
            res = res * 10 + x % 10;
            x /= 10;
        }
        return res;
    }
}

/*
or use long. but this is kind language specific, not good.
 */

public class Solution {
    public int Reverse(int x) {
        long res = 0;
        while (x != 0) {
            res = res * 10 + x % 10;
            if (res > int.MaxValue || res < int.MinValue) return 0;
            x /= 10;
        }
        return (int)res;
    }
}