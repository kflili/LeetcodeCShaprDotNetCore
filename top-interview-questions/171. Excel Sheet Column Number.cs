// base-26 question
public class Solution {
    public int TitleToNumber(string s) {
        int result = 0;
        for (int i = 0; i < s.Length; i++) {
            result = result * 26 + (s[i] - 'A' + 1);
        }
        return result;
    }
}