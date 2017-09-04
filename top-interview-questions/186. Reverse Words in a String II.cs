// a typical rotate array problem, two step reverse method
public class Solution {
    public void ReverseWords(char[] s) {
        Reverse(s, 0, s.Length - 1);    // reverse the whole string first
        int r = 0;
        while (r < s.Length) {
            int l = r;
            while (r < s.Length && s[r] != ' '){
                r++;
            }
            Reverse(s, l, r - 1);    // reverse words one by one
            r++;
        }
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
}