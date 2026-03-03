namespace LeetCodeDaily20260303;
// Naive approach: Generate the string S_n and return the k-th character. Time complexity: O(2^n), Space complexity: O(2^n).
public class Solution {
    public char FindKthBit(int n, int k) {
        string s = "0";
        for (int i = 1; i <= n; i++) {
            s = s + (char)('0' + 1) + ReverseAndFlip(s);
        }
        return s[k - 1];
    }

    private string ReverseAndFlip(string s) {
        char[] arr = s.ToCharArray();
        Array.Reverse(arr);
        for (int i = 0; i < arr.Length; i++) {
            arr[i] = arr[i] == '0' ? '1' : '0';
        }
        return new string(arr);
    }
}