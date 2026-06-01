namespace LeetCodeDaily20260601;

public class Solution {
    public int MinimumCost(int[] cost) {
        Array.Sort(cost);
        int n = cost.Length;
        int totalCost = 0;
        for (int i = 0; i < n; i++) {
            totalCost += cost[i];
        }

        for (int i = n - 2; i >= 0; i -= 2) {
            totalCost -= cost[i];
        }
        return totalCost;
    }
}