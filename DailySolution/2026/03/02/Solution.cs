namespace LeetCodeDaily20260302;
public class Solution {
    public int MinSwaps(int[][] grid) {
        int n = grid.Length;
        int[] checkDuplicate = new int[n];
        int[] zeroCounts = new int[n];
        for (int i = 0; i < n; i++) {
            for (int j = n - 1; j >= 0; j--) {
                if (grid[i][j] == 1) break;
                zeroCounts[i]++;
            }
            checkDuplicate[zeroCounts[i]]++;
            // if (checkDuplicate[zeroCounts[i]] > 1) {
            //     return -1; // If there are duplicate zero counts, it's impossible to arrange
            // }
        }

        // for (int i = 0; i < n; i++) {
        //     Console.WriteLine($"Row {i}: {zeroCounts[i]} trailing zeros");
        // }

        int swaps = 0;
        for (int i = 0; i < n; i++) {
            int minRow = i;
            bool found = false;
            for (int j = i + 1; j < n; j++) {
                if (zeroCounts[j] == n - 1 - i) {
                    minRow = j;
                    found = true;
                    break;
                }
            }
            if (!found) {
                return -1; // If no suitable row is found, it's impossible to arrange
            }
            if (minRow != i) {
                swaps++;
                int temp = zeroCounts[i];
                zeroCounts[i] = zeroCounts[minRow];
                zeroCounts[minRow] = temp;
            }
        }
        return swaps;
    }
}