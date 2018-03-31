/*
O(n) runtime, O(1) space – In-place reverse:
Let us indicate the i th word by w i and its reversal as w i ′. Notice that when you reverse a
word twice, you get back the original word. That is, (w i ′)′ = w i .
The input string is w 1 w 2 … w n . If we reverse the entire string, it becomes w n ′ … w 2 ′ w 1 ′.
Finally, we reverse each individual word and it becomes w n … w 2 w 1 . Similarly, the same
result could be reached by reversing each individual word first, and then reverse the
entire string.
 */

 public class Solution {
    public void ReverseWords(char[] str) {
        if (str == null || str.Length <= 1) return;
        Reverse(str, 0, str.Length - 1);
        int l = 0;
        for (int r = 0; r < str.Length; r++) {
            if (r + 1 == str.Length || str[r + 1] == ' ') {
                Reverse(str, l, r);
                l = r + 2;
            }
        }
    }
    private void Reverse(char[] str, int left, int right) {
        while (left < right) {
            var temp = str[left];
            str[left] = str[right];
            str[right] = temp;
            left++;
            right--;
        }
    }
}

/*
Similar Questions 
Reverse Words in a String
Rotate Array
 */