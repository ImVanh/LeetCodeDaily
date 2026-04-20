namespace LeetCodeDaily20260420;

public class Solution {
    public int MaxDistance(int[] colors) {
        int maxDistance = 0;
        int size = colors.Length;
        for (int i = 0; i < size; i++) {
            for (int j = size - 1; j > i; j--) {
                if (colors[i] != colors[j]) {
                    maxDistance = Math.Max(maxDistance, j - i);
                    break;
                }
            }
        }
        return maxDistance;
    }
}