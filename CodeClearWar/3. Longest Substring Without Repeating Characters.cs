/*
Solution tip: 
    use two start pointer (slower) l = 0, (faster) r = 0.
    use a dictionary to save (char,index). use ans to save maxLen.
    if s[r] is not found in the dictionary, then ans = Math.Max(ans, r - l + 1);
    if s[r] is found in dictonary, then then l should shift to the new index, 
    if dict[s[r]] > l, shift to dict[s[r]] + 1; then ans = Math.Max(ans, r - l + 1);

O(n) runtime, O(n) space – Single iteration:
 */

public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if (s == null || s.Length == 0) return 0;
        int ans = 0;
        int l = 0;
        var dict = new Dictionary<char, int>();
        for (int r = 0; r < s.Length; r++) {
            var cur = s[r];
            if (dict.ContainsKey(cur)) {
                l = Math.Max(l, dict[cur] + 1);
            }
            dict[cur] = r;
            ans = Math.Max(ans, r - l + 1);
        }
        return ans;
    }
}
/*
Next challenges: Longest Substring with At Most Two Distinct Characters
 */

/*
if string only contains ascii. then we can use O(1) space. 
use a int[] charmap = new int[256], instead of dictionary.
 */
public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int[] charMap = new int[256];
        Arrays.fill(charMap, -1);
        int i = 0, maxLen = 0;
        for (int j = 0; j < s.Length; j++) {
            if (charMap[s[j]] >= i) {
                i = charMap[s[j]] + 1;
            }
            charMap[s[j]] = j;
            maxLen = Math.Max(j - i + 1, maxLen);
        }
        return maxLen;
    }
}
/*
By using HashSet as a sliding window, checking if a character in the current can be done in O(1).

A sliding window is an abstract concept commonly used in array/string problems. A window is a 
range of elements in the array/string which usually defined by the start and end indices, 
i.e. [i, j)(left-closed, right-open). A sliding window is a window "slides" its two 
boundaries to the certain direction. For example, if we slide [i, j) to the right by 1 element, 
then it becomes [i+1, j+1) (left-closed, right-open).

Back to our problem. We use HashSet to store the characters in current window [i, j) (j = i initially). 
Then we slide the index j to the right. If it is not in the HashSet, we slide j further. Doing so 
until s[j] is already in the HashSet. At this point, we found the maximum size of substrings 
without duplicate characters start with index ii. If we do this for all i, we get our answer.

Complexity Analysis

Time complexity : O(2n) = O(n). In the worst case each character will be visited twice by i and j.

Space complexity : O(min(m, n)). Same as the previous approach. We need O(k) space for the 
sliding window, where k is the size of the Set. The size of the Set is upper bounded by the 
size of the string n and the size of the charset/alphabet m.
 */

public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int n = s.Length;
        var set = new HashSet<>();
        int ans = 0, i = 0, j = 0;
        while (i < n && j < n) {
            // try to extend the range [i, j]
            if (!set.Contains(s.[j])){
                set.Add(s[j++]));
                ans = Math.Max(ans, j - i);
            }
            else {
                set.Remove(s[i++]);
            }
        }
        return ans;
    }
}