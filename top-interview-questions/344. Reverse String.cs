public class Solution {
    public string ReverseString(string s) {
        if (s == null || s.Length == 0) return s;
        char[] arr = s.ToCharArray();
        for (int i = 0, j = arr.Length - 1; i < j; i++, j--) {
            char temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
        return string.Join("", arr);
        // return new string(arr);
    }
}