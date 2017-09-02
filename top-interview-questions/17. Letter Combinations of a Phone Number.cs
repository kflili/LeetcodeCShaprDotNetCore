// use queue. for each str in q, add new char in str, and put it back
public class Solution {
    public IList<string> LetterCombinations(string digits) {
        if (digits == null || digits.Length == 0) return new List<string>();
        string[] map = { "0", "1", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };
        Queue<string> q = new Queue<string>();
        q.Enqueue("");
        for (int i = 0; i < digits.Length; i++) {
            int num = digits[i] - '0';
            while (q.Peek().Length == i) {
                string preStr = q.Dequeue();
                foreach (char c in map[num]) {
                    q.Enqueue(preStr + c);
                }
            }
        }
        return new List<string>(q);
    }
}