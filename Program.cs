// See https://aka.ms/new-console-template for more information
using LeetCodeDaily20260327;
public class Program {
    public static void Main(string[] args) {
        Solution solution = new Solution();
        bool result = solution.AreSimilar(new int[][] {
            new int[] { 1, 2, 3 },
            new int[] { 4, 5, 6 },
            new int[] { 7, 8, 9 }
        }, 2);
        Console.WriteLine(result); // Output: True
   }
}