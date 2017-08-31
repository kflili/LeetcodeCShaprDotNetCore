/*
We know all multiples of 2 must not be primes, so we mark them off as non-primes. 
Then we look at 3. Similarly, all multiples of 3 must not be primes, so we mark them off as well. 
we can mark off multiples of 5 starting at 5 × 5 = 25, because 5 × 2 = 10 was already marked off 
by multiple of 2, similarly 5 × 3 = 15 was already marked off by multiple of 3. 
*/
public class Solution {
    public int CountPrimes(int n) {
        int count = 0;
        if (n < 2) return count;
        bool[] notPrime = new bool[n];
        for (int i = 2; i < n; i++) {
            if (!notPrime[i]) {
                count++;
                // use i < Math.Sqrt(n) to avoid overflow, which may make j < n
                for (int j = i * i; i < Math.Sqrt(n) && j < n; j += i) {
                    // mark all i * i + k * i to not Prime
                    notPrime[j] = true;
                }
            }
        }
        return count;
    }
}