namespace LeetCodeDaily20261001;

public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();
        foreach (char c in s) {
            if (c == '(' || c == '{' || c == '[') {
                stack.Push(c);
            } else {
                if (stack.Count == 0) return false;
                char open = stack.Pop();
                if (!IsMatchingPair(open, c)) return false;
            }
        }
        return stack.Count == 0;
    }

    private bool IsMatchingPair(char open, char close) {
        return (open == '(' && close == ')') ||
               (open == '{' && close == '}') ||
               (open == '[' && close == ']');
    }
}