/*
The idea is to use one hash set to record sum of every digit square 
of every number occurred. Once the current sum cannot be added to set, 
return false; once the current sum equals 1, return true;
*/

public class Solution {
    public bool IsHappy(int n) {
        HashSet<int> inLoop = new HashSet<int>();
        int squareSum, remain;
        while (inLoop.Add(n)) {
            squareSum = 0;
            while(n > 0) {
                remain = n % 10;
                squareSum += remain * remain;
                n /= 10;
            }
            if (squareSum == 1) {
                return true;
            } else {
                n = squareSum;
            }
        }
        return false;
    }
}