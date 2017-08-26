// condense and smart one, not a direct thought
public class Solution {
    public bool IsValid(string s) {
        if (s == null || s.Length == 0) return false;
        if (s.Length % 2 == 1) return false;
        Stack<char> stack = new Stack<char>();
        foreach (char c in s) {
            if (c == '(') stack.Push(')');
            else if (c == '[') stack.Push(']');
            else if (c == '{') stack.Push('}');
            else if (stack.Count == 0 || stack.Pop() != c) return false;
        }
        return stack.Count == 0;
    }
}

// direct thought solution
public class Solution {
    public bool IsValid(string s) {
        if (s == null || s.Length == 0) return false;
        if (s.Length % 2 == 1) return false;
        Stack<char> stack = new Stack<char>();
        foreach (char c in s) {
            if (c == '(' || c == '[' || c == '{') stack.Push(c);
            else if (stack.Count == 0) return false;
            else if (c == ')' && stack.Peek() == '(') stack.Pop();
            else if (c == ']' && stack.Peek() == '[') stack.Pop();
            else if (c == '}' && stack.Peek() == '{') stack.Pop();
            else return false;
        }
        return stack.Count == 0;
    }
}