// solution  use slicing windows
public class Solution {
    public IList<int> FindAnagrams(string s, string p) {
        IList<int> list = new List<int>();
        if (s == null || p == null | s.Length < p.Length) {
            return list;
        }
        // record each char in p to hash
        int[] hash = new int[128]; // a ~ z: 97 ~ 122.
        foreach (char c in p) {
            hash[c]++; // key: char, value: occuring times
        }
        // two pointers for slicing window
        int left = 0, right = 0, matched = 0;

        while (right < s.Length) {
            //current hash value >= 1 means the character is existing in p, matched increse 1
            char rightChar = s[right];
            if (hash[rightChar] >= 1) {
                matched++;
            }
            // decrease the occuring times for rightChar, 
            // it's value will be < 0, if rightChar doesn't exist in p
            hash[rightChar]--;
            right++; // move right pointer

            // when the matched == p.Length means we found the right anagram
            // then add window's left to result list
            // keep in mind, matched won't reached p.Length if any non-matching char inside window.
            if (matched == p.Length) {
                list.Add(left);
            }

            // if we find the window's size equals to p, then we have to move left (narrow the window) to find the new match window
            if (right - left == p.Length) {
                char leftChar = s[left];
                // the value >= 0 indicate it was original in the hash, 
                // otherwise it's < 0. So matched--, because we kicked out the matching char
                if (hash[leftChar] >= 0) {
                    matched--;
                }
                hash[leftChar]++;
                left++;
            }
        }
        return list;
    }
}