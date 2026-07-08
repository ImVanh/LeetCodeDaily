namespace LeetCodeDaily20260707;

public class Solution {
    public long SumAndMultiply(int n) {
        long sum = 0;
        int [] nums = new int[n];
        int i = 0;

        while (n > 0)
        {
            nums[i] = n % 10;
            n /= 10;
        }

        long product = 1;
        for (int j = 0; j < i; j++)
        {
            product += nums[j];
        }

        int k = 0;

        for (int j = i; j >= 0; j--)
        {
            sum = sum * k + nums[j] * product;
        }

        return sum;
    }
}