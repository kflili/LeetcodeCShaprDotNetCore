/* O(n) runtime, O(n) space:
One simple approach is a two-pass solution: First pass to split the string by spaces into an
array of words, then second pass to extract the words in reversed order.
We can do better in one-pass. While iterating the string in reverse order, we keep track of
a word’s begin and end position. When we are at the beginning of a word, we append it. */
public class Solution {
    public string ReverseWords(string s) {
        if (s == null || s.Length == 0) return "";
        int j = s.Length;
        var str = new StringBuilder();
        for (int i = s.Length - 1; i >= 0; i--) {
            if (s[i] == ' ') {
                j = i;
            } else if (i == 0 || s[i - 1] == ' ') {
                if (str.Length != 0) {
                    str.Append(' ');
                }
                str.Append(s.Substring(i, j - i));
            }
        }
        return str.ToString();
    }
}

// use buildin trim and split
public class Solution {
    public string ReverseWords(string s) {
        if (s == null || s.Length == 0 ) return "";
        string[] array = s.Split(' ');
        StringBuilder sb = new StringBuilder();
        for (int i = array.Length - 1; i >= 0; i--) {
            if (array[i].Trim() != "") {
                sb.Append(array[i]).Append(" ");
            }
        }
        // remove last " "
        return sb.ToString().TrimStart().TrimEnd();
    }
}