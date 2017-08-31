/*
10 is the product of 2 and 5. In n!, we need to know how many 
2 and 5, and the number of zeros is the minimum of the number 
of 2 and the number of 5.
For each step 5, there're 2 even number inside, so 2's count is 
way more than 5's count. Just need count 5 fators.
n/5 get how many 5 steps, but other than that, 
note 25's mutiplies gives one more 5.
say, 26! not only five 5s, it's six 5s, because 25 give one more 5.
so the count = n / 5 + n / 25 + n / 125 + ...
 */
public class Solution {
    public int TrailingZeroes(int n) {
        int count = 0;
        while (n > 0) {
            count += n / 5;
            n /= 5;
        }
        return count;
    }
}