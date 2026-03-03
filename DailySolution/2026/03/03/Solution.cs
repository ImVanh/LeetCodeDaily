namespace LeetCodeDaily20260303;
// // Naive approach: Generate the string S_n and return the k-th character. Time complexity: O(2^n), Space complexity: O(2^n).
// public class Solution {
//     public char FindKthBit(int n, int k) {
//         string s = "0";
//         for (int i = 1; i <= n; i++) {
//             s = s + (char)('0' + 1) + ReverseAndFlip(s);
//         }
//         return s[k - 1];
//     }

//     private string ReverseAndFlip(string s) {
//         char[] arr = s.ToCharArray();
//         Array.Reverse(arr);
//         for (int i = 0; i < arr.Length; i++) {
//             arr[i] = arr[i] == '0' ? '1' : '0';
//         }
//         return new string(arr);
//     }
// }

public class Solution {
    public char FindKthBit(int n, int k) {
        if (n == 1) return '0';
        int size = (1 << n) - 1; // Length of S_n
        Console.WriteLine($"Size of S_{n}: {size}");
        return GetKthBit(size, k);
    }

    private char GetKthBit(int size, int k)
    {
        if (k == 1) return '0';
        int mid = size / 2 + 1; // Middle index of S_n
        if (k == mid) return '1';
        if (k < mid) return GetKthBit(mid - 1, k);
        char bit = GetKthBit(mid - 1, size - k + 1);
        return bit == '0' ? '1' : '0';
    }
}