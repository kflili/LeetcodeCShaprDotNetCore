/*
In general, for each bit, we can choose either "(" or ")", but in this problem.
To get paired solution, for each bit site, there are some restrictions.
To add "(": there must be some "(" remaining.
To add ")": 1, there must be some "(" remaining.
            2, previous acount of "(" must be more than ")".
            1 + 2 => remainning "(" less than ")"

 */
public class Solution {
    public IList<string> GenerateParenthesis(int n) {
        IList<string> result = new List<string>();
        if (n > 0) DFSHelper(result, "", n, n);
        return result;
    }
    private void DFSHelper(IList<string> result, string s, int left, int right) {
        if (left == 0 && right == 0) result.Add(s);
        // has remaining "("
        if (left > 0) DFSHelper(result, s + "(", left - 1, right);
        // has more ")" remain
        if (right > 0 && right > left) DFSHelper(result, s + ")", left, right - 1);
    }
}