namespace LeetCodeDaily20260904;

public class Solution {
    public int FirstStableIndex(int[] nums, int k) {
        // prefix
        int n = nums.Length;
        int[] maxArr = new int[n];
        int[] minArr = new int[n];

        maxArr[0] = nums[0];
        minArr[n - 1] = nums[n - 1];

        for (int i = 1; i < n; i++) {
            maxArr[i] = Math.Max(maxArr[i - 1], nums[i]);
            minArr[n - 1 - i] = Math.Min(minArr[n - i], nums[n - 1 - i]);
        }
        for (int i = 0; i < n; i++) {
            if (maxArr[i] - minArr[i] <= k) {
                return i;
            }
        }
        return -1;
    }
}