// core feature need learn the remove sapce method.
public class Solution {
    public string ReverseWords(string s) {
        if (s == null || s.Length < 1) return s;
        char[] arr = s.ToCharArray();
        // reverse whole string
        Reverse(arr, 0, arr.Length - 1);
        // remove unnecessary space
        char[] newArr = RemoveNonUseSpace(arr).ToCharArray();
        // reverse words one by one
        int r = 0;
        while (r < newArr.Length) {
            int l = r;
            while (r < newArr.Length && newArr[r] != ' '){
                r++;
            }
            Reverse(newArr, l, r - 1);    // reverse words one by one
            r++;
        }
        return new string(newArr);
    }
    private void Reverse(char[] s, int left, int right) {
        if (s == null || s.Length == 0 || left > right) return;
        while (left < right) {
            char temp = s[left];
            s[left] = s[right];
            s[right] = temp;
            left++;
            right--;
        }
    }
    public string RemoveNonUseSpace(char[] s) {
        int startIndex = 0;  // point to the good index ready to insert word
        for (int i = 0; i < s.Length; i++) {
            if (s[i] != ' ') {
                if (startIndex != 0) s[startIndex++] = ' ';  // add one space before inserting word
                int wordScanner = i;  // s[i] != ' ', set as the starting point for new word
                // start scanning the new word, and copy to startIndex
                while (wordScanner < s.Length && s[wordScanner] != ' ') {
                    s[startIndex++] = s[wordScanner++];
                }
                // wordScanner exceeds the word range, pointing to ' ', move i to here, ready for next i loop
                i = wordScanner;
            }
        }
        return new string(s, 0, startIndex);
    }
}