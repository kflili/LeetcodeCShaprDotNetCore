public class Solution {
    public bool IsPalindrome(string s) {
        if (s.Length == 0) return true;
        int left = 0, right = s.Length - 1;
        char leftChar, rightChar;
        while (left <= right) {
            leftChar = s[left];
            rightChar = s[right];
            if (!char.IsLetterOrDigit(leftChar)){
                left++;
            } else if (!char.IsLetterOrDigit(rightChar)) {
                right--;
            } else {
                if (char.ToLower(leftChar) != char.ToLower(rightChar)) {
                    return false;
                }
                left++;
                right--;
            }
        }
        return true;
    }
}