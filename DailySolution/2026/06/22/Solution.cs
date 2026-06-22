namespace LeetCodeDaily20260622;

public class Solution {
    public int MaxNumberOfBalloons(string text) {
        int[] count = new int[26];
        foreach (char c in text) {
            count[c - 'a']++;
        }

        int countB = count['b' - 'a'];
        int countA = count['a' - 'a'];
        int countL = count['l' - 'a'] / 2;
        int countO = count['o' - 'a'] / 2;
        int countN = count['n' - 'a'];

        return Math.Min(countB, Math.Min(countA, Math.Min(countL, Math.Min(countO, countN))));
    }
}