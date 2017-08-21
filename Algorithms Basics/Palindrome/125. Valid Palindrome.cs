
public class Solution {
    public bool IsPalindrome(string s) {
        if (s.Length == 0) return true;
        int left = 0, right = s.Length - 1;
        while (left < right) {
            while (left < right && !char.IsLetterOrDigit(s[left])){
                left++;
            } 
            if (left == right) break;
            while (left < right && !char.IsLetterOrDigit(s[right])) {
                right--;
            }
            if (left == right) break;
            if (char.ToLower(s[left]) != char.ToLower(s[right])) {
                return false;
            }
            left++;
            right--;
            
        }
        return true;
    }
}   