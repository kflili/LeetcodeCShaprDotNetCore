/*
1. If | n – m | is greater than 1, we know immediately both are not one-edit distance
apart.
2. It might help if you consider these cases separately, m == n and m ≠ n.
3. Assume that m is always ≤ n, which greatly simplifies the conditional statements.
If m > n, we could just simply swap S and T.

i. Modify operation – Modify a character to X in S.
S = “abcde”
T = “abXde”
ii. Insert operation – X was inserted before a character in S.
S = “abcde”
T = “abcXde”
iii. Append operation – X was appended at the end of S.
S = “abcde”
T = “abcdeX”
 */

public class Solution {
    public bool IsOneEditDistance(string s, string t) {
        int m = s.Length, n = t.Length;
        if (m > n) {
            return IsOneEditDistance(t, s);
        }
        if (n - m > 1) return false;
        for (int i = 0; i < m; i++) {
            if (s[i] != t[i]) {
                if (m == n) {
                    // case i S = “abcde” T = “abXde”
                    return s.Substring(i + 1, m - i - 1).Equals(t.Substring(i + 1, m - i - 1));
                }
                // case ii S = “abcde” T = “abcXde”
                return s.Substring(i, m - i).Equals(t.Substring(i + 1, m - i));
            }
        }
        // case iii t has one more char in the end, return true; edge case, s == t, return false
        return m + 1 == n;
    }
}

/*
Next challenges: Edit Distance
 */