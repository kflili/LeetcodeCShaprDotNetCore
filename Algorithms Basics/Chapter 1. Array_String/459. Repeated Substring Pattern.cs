public class Solution {
    public bool RepeatedSubstringPattern(string s) {
        int l = s.Length;
        for (int i = l / 2; i >= 1; i--) {
            if (l % i == 0) {
                int m = l / i;
                string subS = s.Substring(0, i);
                StringBuilder sb = new StringBuilder();
                for (int j = 0; j < m; j++) {
                    sb.Append(subS);
                }
                if (sb.ToString().Equals(s)) return true;
            }
        }
        return false;
    }
}
public class Solution2 {
    public bool RepeatedSubstringPattern(string s) {
        int l = s.Length;
        for (int i = l / 2; i >= 1; i--) {
            if (l % i == 0) {
                int m = l / i;
                string subS = s.Substring(0, i);
                int j;
                for (j = 1; j < m; j++) {
                    if (subS != s.Substring(j * i, i)) break;
                }
                if (j == m) return true;
            }
        }
        return false;
    }
}