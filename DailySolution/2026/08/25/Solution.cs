public class Solution {
    public int MissingMultiple(int[] nums, int k) {
        bool[] dict = new bool[101];
        for (int i = 0; i < nums.Length; i++)
        {
            dict[nums[i]] = true;
        }

        for (int i = 1; i < 1000/k; i++)
        {
            if (i * k >= 101) return i * k;
            if (!dict[i * k])
            {
                return i * k;
            }
        }
        return 1;
    }
}