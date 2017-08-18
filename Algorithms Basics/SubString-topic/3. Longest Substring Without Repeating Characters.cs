public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int ans = 0;
        if (s == null || s.Length == 0) {
            return ans;
        }
        int left = 0, right = 0;
        var dict = new Dictionary<char, int>();
        while (right < s.Length) {
            char tempChar = s[right];
            if (dict.ContainsKey(tempChar)) {
                // very important, bug prone!!
                left = Math.Max(left, dict[tempChar] + 1);
            }
            dict[tempChar] = right;
            ans = Math.Max(ans, right - left + 1);
            right++;
        }
        return ans;
    }
}