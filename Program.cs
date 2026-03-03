// See https://aka.ms/new-console-template for more information
using LeetCodeDaily20260302;
public class Program {
    public static void Main(string[] args) {
        Solution solution = new Solution();
        int result = solution.MinSwaps(new int[][] {
            new int[] { 1, 0, 0, 1 },
            new int[] { 1, 1, 1, 1 },
            new int[] { 1, 1, 1, 1 },
            new int[] { 1, 0, 0, 0 }
        });
        Console.WriteLine(result); // Output: 3
   }
}