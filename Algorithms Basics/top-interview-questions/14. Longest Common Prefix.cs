// Pick char from strs[0]. for each char at index i, check if match
// with char at index i in other strings.

public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if (strs == null || strs.Length == 0) return "";
        for (int i = 0; i < strs[0].Length; i++) {
            char c = strs[0][i];
            int j = 0;
            for (j = 1; j < strs.Length; j++) {
                if (i == strs[j].Length || strs[j][i] != c) {
                    return strs[0].Substring(0, i);
                }
            }
        }
        return strs[0];
    }
}