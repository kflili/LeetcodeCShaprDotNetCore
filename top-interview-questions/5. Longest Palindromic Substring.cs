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