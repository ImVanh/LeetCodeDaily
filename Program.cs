// See https://aka.ms/new-console-template for more information
using LeetCodeDaily.Solution25022026;

public class Program {
    public static void Main(string[] args) {
        Solution solution = new Solution();
        int[] result = solution.SortByBits(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 });
        Console.WriteLine(string.Join(", ", result)); // Output: 0, 1, 2, 4, 8, 3, 5, 6, 7
   }
}