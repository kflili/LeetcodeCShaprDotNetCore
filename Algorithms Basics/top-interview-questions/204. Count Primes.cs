public class Solution {
    public int CountPrimes(int n) {
        int count = 0;
        if (n < 2) return count;
        bool[] notPrime = new bool[n];
        for (int i = 2; i < n; i++) {
            if (!notPrime[i]) {
                count++;
                // use  i < Math.Sqrt(n) to avoid overflow, which may make j < n while actual i * i > n
                for (int j = i * i; i < Math.Sqrt(n) && j < n; j += i) {
                    // mark all i * i + k * i to not Prime
                    notPrime[j] = true;
                }
            }
        }
        return count;
    }
}