/*
O(n^2) runtime, O(1) space – Simpler solution:
In fact, we could solve it in O(n^2) time using only constant space.
We observe that a palindrome mirrors around its center. Therefore, a palindrome can be
expanded from its center, and there are only 2n – 1 such centers.
You might be asking why there are 2n – 1 but not n centers? The reason is the center of a
palindrome can be in between two letters. Such palindromes have even number of letters
(such as “abba”) and its center are between the two ‘b’s.
Since expanding a palindrome around its center could take O(n) time, the overall
complexity is O(n^2).

 */

public class Solution {
    public string LongestPalindrome(string s) {
        int start = 0, maxLen = 0;
        for (int i = 0; i < s.Length; i++) {
            //assume odd length, try to extend Palindrome as possible "xxaxx"
            var len1 = ExpandAroundCenter(s, i, i);
            //assume even length. "xxbbxx"
            var len2 = ExpandAroundCenter(s, i, i + 1);
            var len = len1 > len2 ? len1 : len2;
            if (len > maxLen) {
                start = i - (len - 1) / 2;
                maxLen = len;
            }
        }
        return s.Substring(start, maxLen);
    }
    private int ExpandAroundCenter(string s, int left, int right) {
        while (left >= 0 && right < s.Length && s[left] == s[right]) {
            left--; right++;
        }
        // outside the loop, the s[left + 1] == s[right - 1]
        return (right - 1) - (left + 1) + 1;
    }
}