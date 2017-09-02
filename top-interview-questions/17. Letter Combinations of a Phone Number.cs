// iteration: use queue. for each str in q, add new char in str, and put it back
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

/* Iteration: 
easy understand, for result, every time add char to the results
 */

public class Solution {
    public List<String> LetterCombinations(String digits) {
        string[] map = { "0", "1", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };
        List<String> result = new List<String>();
        if (digits.Length == 0) return result;
        result.Add("");
        for (int i = 0; i < digits.Length; i++)
            result = Combine(map[digits[i] - '0'], result);
        return result;
    }

    private List<String> Combine(string digit, List<String> l) {
        List<String> result = new List<String>();
        for (int i = 0; i < digit.Length; i++)
            foreach (string x in l)
                result.Add(x + digit[i]);
        return result;
    }
}

// Recursion:
public class Solution {
    private string[] map = { "0", "1", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };
    public IList<string> LetterCombinations(string digits) {
        List<string> result = new List<string>();
        if (digits == null || digits.Length == 0) return result;
        helper("", 0, digits, result);
        return result;
    }
    private void helper(string prefix, int scanIndex, string digits, List<string> result) {
        if (scanIndex == digits.Length) {
            // if there's no empty string in map, we can also use prefix.Length == digits.Length here.
            result.Add(prefix);
            return;
        }
        int number = digits[scanIndex] - '0';
        foreach(char c in map[number]) {
            helper(prefix + c, scanIndex + 1, digits, result);
        }
    }
}