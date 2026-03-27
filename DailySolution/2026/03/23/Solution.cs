namespace LeetCodeDaily20260323;
public class Solution {
    public int MaxProductPath(int[][] grid) {
        int max = -1;
        int m = grid.Length;
        int n = grid[0].Length;
        int mod = 1000000007;
        long[][] dpMax = new long[m][];
        long[][] dpMin = new long[m][];
        for (int i = 0; i < m; i++)         {
            dpMax[i] = new long[n];
            dpMin[i] = new long[n];
        }
        dpMax[0][0] = grid[0][0];
        dpMin[0][0] = grid[0][0];
        for (int i = 1; i < m; i++)
        {
            dpMax[i][0] = dpMax[i - 1][0] * grid[i][0];
            dpMin[i][0] = dpMin[i - 1][0] * grid[i][0];
        }

            for (int j = 1; j < n; j++)
            {
                dpMax[0][j] = dpMax[0][j - 1] * grid[0][j];
                dpMin[0][j] = dpMin[0][j - 1] * grid[0][j];
            }
        for (int i = 1; i < m; i++)
        {
            for (int j = 1; j < n; j++)
            {
                if (i == 0 && j == 0) continue;
                long upMaxValue = getUpValue(dpMax, i, j) ?? 0;
                long leftMaxValue = getLeftValue(dpMax, i, j) ?? 0;
                long upMinValue = getUpValue(dpMin, i, j) ?? 0;
                long leftMinValue = getLeftValue(dpMin, i, j) ?? 0;
                long currentValue = grid[i][j];
                if (currentValue >= 0)
                {
                    dpMax[i][j] = Math.Max(upMaxValue, leftMaxValue) * currentValue;
                    dpMin[i][j] = Math.Min(upMinValue, leftMinValue) * currentValue;
                    } else
                    {
                        dpMax[i][j] = Math.Min(upMinValue, leftMinValue) * currentValue;
                        dpMin[i][j] = Math.Max(upMaxValue, leftMaxValue) * currentValue;
                    }
                }
            }
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(dpMax[i][j] + " ");
                }
                Console.WriteLine();
            }
            return dpMax[m - 1][n - 1] < 0 ? -1 : (int)(dpMax[m - 1][n - 1] % mod);
        }

    private long? getUpValue(long[][] grid, int i, int j) {
        if (i == 0) return null;
        return grid[i - 1][j];
    }

    private long? getLeftValue(long[][] grid, int i, int j) {
        if (j == 0) return null;
        return grid[i][j - 1];
    }
}