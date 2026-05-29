namespace LeetCodeDaily20260529;
public class Solution {
    public int MinElement(int[] nums) {
        int min = nums[0];
        foreach (int num in nums) {
            min = Math.Min(min, CalculateSumDigits(num));
        }
        return min;
    }

    private int CalculateSumDigits(int num)
    {
        int sum = 0;
        while (num > 0)
        {
            sum += num % 10;
            num /= 10;
        }
        return sum;
    }
}