namespace LeetCodeDaily20260305;
public class Solution
{
    // Example Input: s = "0100"
    // Output: 1
    // Explanation: If you change the last character to '1', s will be "0101", which is alternating.
    public int MinOperations(string s) {
        int changes = 0;
        char current = s[0];
        for (int i = 1; i < s.Length; i++) {
            if (s[i] == current) {
                changes++;
                current = Flip(current);
            } else {
                current = s[i];
            }
        }

        int changes2 = 1;
        current = Flip(s[0]);
        for (int i = 1; i < s.Length; i++) {
            if (s[i] == current) {
                changes2++;
                current = Flip(current);
            } else {
                current = s[i];
            }
        }
        return Math.Min(changes, changes2);
    }

    private char Flip(char c) {
        return c == '0' ? '1' : '0';
    }
}