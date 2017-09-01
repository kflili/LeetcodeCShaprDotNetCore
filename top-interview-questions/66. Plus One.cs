// add from last digit
public class Solution {
    public int[] PlusOne(int[] digits) {
        if (digits == null || digits.Length == 0) return null;
        int n = digits.Length;
        for (int i = n - 1; i >= 0; i--) {
            if (digits[i] < 9) {
                digits[i]++;
                return digits;
            }
            digits[i] = 0;
        }
        int[] newDigits = new int[n + 1];
        newDigits[0] = 1;
        return newDigits;
    }
}