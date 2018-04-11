// check left == right.
// left = x / div; right = x % 10;
// how to find div? note: x / div < 10

public class Solution {
    public bool IsPalindrome(int x) {
        if (x < 0) return false;
        int div = 1;
        // find the intial value of div
        while (x / div >= 10) {
            div *= 10;
        }
        while (x > 0) {
            int l = x / div;
            int r = x % 10;
            if (l != r) return false;
            // remove both the left and right number
            x = (x % div) / 10;
            // removed two numbers, so div = div / 100;
            div /= 100;
        }
        return true;
    }
}

// reverse the second half
public class Solution {
    public bool IsPalindrome(int x) {
        if (x < 0 || (x != 0 && x % 10 == 0)) return false;
        int rev = 0;
        while (x > rev) {
            rev = rev * 10 + x % 10;
            x = x / 10;
        }
        return (x == rev || x == rev / 10);
    }
}

/*
Next challenges: Palindrome Linked List
 */