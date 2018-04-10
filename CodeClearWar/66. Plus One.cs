/*
Iterate from the least significant digit, and simulate by adding one to it. Adding one to a
digit less than nine is straightforward – Add one to it and we are done.
On the other hand, adding one to a digit of 9 brings it to 10, so we set the digit to 0 and
continues with a carry digit of one to its left digit. Notice this recursive behavior? Yes,
we are adding one again to its left digit and this behavior continues until the most
significant digit.
Finally, be sure that you handle the edge case where each digit of the number is 9.

 O(n) runtime, O(1) space or O(n) space
 */

public class Solution {
    public int[] PlusOne(int[] digits) {
        int n = digits.Length;
        for (int i = n - 1; i >= 0; i--) {
            if (digits[i] < 9) {
                digits[i]++;
                return digits;
            } else {
                digits[i] = 0;
            }
        }
        int[] newDigits = new int[n + 1];
        newDigits[0] = 1;
        return newDigits;
    }
}