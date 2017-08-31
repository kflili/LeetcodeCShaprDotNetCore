public class Solution {
    public string CountAndSay(int n) {
        string preStr = "1";
        while (n-- > 1) {
            StringBuilder sb = new StringBuilder();
            for (int i = 1, count = 1; i <= preStr.Length; i++, count++) {
                if (i == preStr.Length || preStr[i] != preStr[i - 1]) {
                    sb.Append(count).Append(preStr[i - 1]);
                    count = 0;
                }
            }
            preStr = sb.ToString();
        }
        return preStr;
    }
}