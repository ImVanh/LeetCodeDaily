namespace LeetCodeDaily20260825;

public class Solution {
    public int MissingMultiple(int[] nums, int k) {
        bool[] dict = new bool[101];
        for (int i = 0; i < nums.Length; i++)
        {
            dict[nums[i]] = true;
        }

        for (int i = 0; i < 200/k; i++)
        {
            if (!dict[i * k])
            {
                return i * k;
            }
        }
        return 1;
    }
}