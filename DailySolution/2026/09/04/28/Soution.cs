namespace LeetCodeDaily20260928;

public class Solution {
    public int MaxDepth(string s) {
        int depth = 0;

        int currentDepth = 0;
        Queue<char> stack = new Queue<char>();
        foreach (char c in s) {
            if (c == '(') {
                stack.Enqueue(c);
                currentDepth++;
                depth = Math.Max(depth, currentDepth);
            } else if (c == ')') {
                if (stack.Count > 0) {
                    stack.Dequeue();
                    currentDepth--;
                }
            }
        }
        return depth;
    }
}