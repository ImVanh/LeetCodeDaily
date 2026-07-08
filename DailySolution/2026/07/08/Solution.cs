namespace LeetCodeDaily20260708;

public class Solution {
    public int[] SumAndMultiply(string s, int[][] queries) {

        int[] result = new int[queries.Length];
        int mod = 1000000007;

        long[] prefixSum = new long[s.Length + 1];

        for (int i = 0; i < s.Length; i++)
        {
            int digit = s[i] - '0';
            prefixSum[i + 1] = prefixSum[i] + digit;
        }

        for (int i = 0; i < queries.Length; i++)
        {
            int left = queries[i][0];
            int right = queries[i][1];

            long sum = prefixSum[right + 1] - prefixSum[left];
            // Console.WriteLine(sum);
            long product = 0;
            for (int j = left; j <= right; j++)
            {
                if (s[j] == '0') continue; // Skip zeros to avoid multiplying by zero
                product = (product * 10 + sum * (s[j] - '0')) % mod;
            }

            result[i] = (int)(product % mod);
        }

        return result;    
    }
}