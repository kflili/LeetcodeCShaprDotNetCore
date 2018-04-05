/*
solution: same approach as in 159;
 */

public class Solution {
    public int LengthOfLongestSubstringKDistinct(string s, int k) {
        int maxLen = 0;
        if (s == null || s.Length == 0 || k == 0) return maxLen;
        int i = 0, numDistinct = 0;
        var dict = new Dictionary<char,int>();
        for (int j = 0; j < s.Length; j++) {
            if (!dict.ContainsKey(s[j]) || dict[s[j]] == 0) {
                numDistinct++;
                dict[s[j]] = 1;
            } else {
                dict[s[j]]++;
            }
            while (numDistinct > k) {
                dict[s[i]]--;
                if (dict[s[i]] == 0) numDistinct--;
                i++;
            }
            maxLen = Math.Max(maxLen, j - i + 1);
        }
        return maxLen;
    }
}

/*
Next challenges: 
Longest Repeating Character Replacement
 */