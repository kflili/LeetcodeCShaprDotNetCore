/*
for each point, try to expand to palindrom, and compare with maxLen.
 */
public class Solution {
    private int start, maxLen;
    public string LongestPalindrome(string s) {
        int len = s.Length;
        if (len < 2) return s;
        for (int i = 0; i < s.Length - 1; i++) {
            //assume odd length, try to extend Palindrome as possible
            ExpandAroundCenter(s, i, i);
            //assume even length.
            ExpandAroundCenter(s, i, i + 1);
        }
        return s.Substring(start, maxLen);
    }
    private void ExpandAroundCenter(string s, int left, int right) {
        while ( left >= 0 && right < s.Length && s[left] == s[right]) {
            left--;
            right++;
        }
        if (maxLen < right - left - 1) {
            start = left + 1;
            maxLen = right - left - 1;
        }
    }
}

// Dynamic Programming
/*
consider whether using this new character as end could produce new palindrome 
string of length (current length +1) or (current length +2), no more than length + 3;
 */
public class Solution {
    public String LongestPalindrome(String s) {
        int maxLen = 0;
        int start = -1;
        for (int i = 0; i < s.Length; i++) {
            if (IsPalindrome(s, i - maxLen - 1, i)) {
                start = i - maxLen - 1;
                maxLen += 2;
            } else if (IsPalindrome(s, i - maxLen, i)) {
                start = i - maxLen;
                maxLen += 1;
            }
        }
        return s.Substring(start, maxLen);
    }
    private bool IsPalindrome(string s, int start, int end) {
        if (start < 0) {
            return false;
        }
        while (start < end) {
            if (s[start++] != s[end--]) {
                return false;
            }
        }
        return true;
    }
}