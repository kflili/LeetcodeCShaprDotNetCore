/*
Similar problems:
438. Find All Anagrams in a String
 */
public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s == null) return t == null;
        if (t == null) return false;
        int m = s.Length, n = t.Length;
        if (m != n) return false;
        var dict = new Dictionary<char, int>();
        for (var i = 0; i < m; i++) {
            if (!dict.ContainsKey(s[i])) {
                dict[s[i]] = 1;
            } else {
                dict[s[i]]++;
            }
        }
        for (var i = 0; i < n; i++) {
            if (!dict.ContainsKey(t[i])) {
                return false;
            }
            dict[t[i]]--;
            if (dict[t[i]] < 0) {
                return false;
            }
        }
        return true;
    }
}