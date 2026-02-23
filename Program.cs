// See https://aka.ms/new-console-template for more information
public class Program {
    public static void Main(string[] args) {
        Solution solution = new Solution();
        string s = "0110";
        int k = 1;
        bool result = solution.HasAllCodes(s, k);
        Console.WriteLine(result); // Output: true
    }
}