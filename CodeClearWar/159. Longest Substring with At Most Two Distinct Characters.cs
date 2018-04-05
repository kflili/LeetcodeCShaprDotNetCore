/*
The trick is to maintain a sliding window that always satisfies the invariant where there
are always at most two distinct characters in it. When we add a new character that breaks
this invariant, how can we move the begin pointer to satisfy the invariant?

we can use a dictionary to save times for each char, and use a counter to save the num of distinct.

when moving the right pointer, we increase the appear times, also increase the counts of distinct char
 when meet new char;
when moving the left pointer, we decrease the appear times, and decrease the counts if the appear times = 0;

O(n) run time, O(n) space.
 */

public class Solution {
    public int LengthOfLongestSubstringTwoDistinct(string s) {
        int maxLen = 0;
        if (s == null || s.Length == 0) return maxLen;
        var dict = new Dictionary<char, int>();
        int i = 0, numDistinct = 0;
        for (int j = 0; j < s.Length; j++) {
            if (!dict.ContainsKey(s[j]) || dict[s[j]] == 0) {
                dict[s[j]] = 1;
                numDistinct++;
            } else {
                dict[s[j]] += 1;
            }
            while (numDistinct > 2) {
                dict[s[i]] -= 1;
                if (dict[s[i]] == 0) numDistinct--;
                i++;
            }
            maxLen = Math.Max(maxLen, j - i + 1);
        }
        return maxLen;
    }
}

/*
Similar Questions 
Longest Substring Without Repeating Characters
Sliding Window Maximum
Longest Substring with At Most K Distinct Characters

 */

/*
if string only contains ascii, then we can use int[256] to save as O(1) space.
 */

public class Solution {
    public int LengthOfLongestSubstringTwoDistinct(string s) {
        int maxLen = 0;
        if (s == null || s.Length == 0) return maxLen;
        var dict = new int[256];
        int i = 0, numDistinct = 0;
        for (int j = 0; j < s.Length; j++) {
            if (dict[s[j]] == 0) numDistinct++;
            dict[s[j]]++;
            while (numDistinct > 2) {
                dict[s[i]]--;
                if (dict[s[i]] == 0) numDistinct--;
                i++;
            }
            maxLen = Math.Max(maxLen, j - i + 1);
        }
        return maxLen;
    }
}