// very important and tricky!!!!! n-- first!!!
public class Solution {
    public string ConvertToTitle(int n) {
        StringBuilder sb = new StringBuilder();
        while (n > 0) {
            n--;  // very important!!! and tricky!!!
            sb.Insert(0, (char)('A' + n % 26));
            n /= 26;
        }
        return sb.ToString();
    }
}