public class Solution {
    public int RomanToInt(string s) {
        if (s == null || s.Length == 0) return 0;
        Dictionary<char, int> dict = new Dictionary<char, int>() {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000},
        };
        int sum = dict[s[s.Length - 1]];
        for (int i = s.Length - 2; i >= 0; i--) {
            if (dict[s[i]] < dict[s[i + 1]]) {
                sum -= dict[s[i]];
            } else {
                sum += dict[s[i]];
            }
        }
        return sum;
    }
}