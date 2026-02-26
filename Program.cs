// See https://aka.ms/new-console-template for more information
using LeetCodeDaily.Solution24022026;

public class Program {
    public static void Main(string[] args) {
        Solution solution = new Solution();
        int result = solution.SumRootToLeaf(new TreeNode(1, new TreeNode(0, new TreeNode(0), new TreeNode(1)), new TreeNode(1, new TreeNode(0), new TreeNode(1))));
        Console.WriteLine(result); // Output: 6
   }
}