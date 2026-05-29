// See https://aka.ms/new-console-template for more information
using LeetCodeDaily20260529;
public class Program {
    public static void Main(string[] args) {
        Solution solution = new Solution();
        int result = solution.MinElement(new int[] { 1,1,1,6,1,1,1 });
        Console.WriteLine(result); // Output: 1
   }
}