public class Solution {
    public int FirstUniqChar(string s) {
        var dict = new Dictionary<char, int>();
        for (int i = 0; i < s.Length; i++) {
            char c = s[i];
            if (dict.ContainsKey(c)) {
                dict[c]++;
            } else {
                dict.Add(c, 1);
            }
        }
        for (int i = 0; i < s.Length; i++) {
            if (dict[s[i]] == 1) return i;
        }
        return -1;
    }
}