/*
Similar Problem:
459. Repeated Substring Pattern
 */
public class Solution {
    public int StrStr(string haystack, string needle) {
        if (haystack == null || needle == null) {
            return -1;
        }
        int m = haystack.Length, n = needle.Length;
        if (n == 0) return 0;
        if (m < n) return -1;
        for (int i = 0; i < m - n; i++) {
            int j = 0;
            for (j = 0; j < n; j++) {
                if (haystack[i + j] != needle[j])
                    break;
            }
            if (j == n) return i;
        }
        return -1;
    }
}

/*
Next challenges: 
Shortest Palindrome
Repeated Substring Pattern
 */