public class Solution {
    public bool HasAllCodes(string s, int k) {
        // Produce all possible binary codes of length k using backtracking
        HashSet<string> allCodes = new HashSet<string>();
        Backtrack(k, "", allCodes);
        foreach (string code in allCodes) {
            Console.WriteLine(code);
        }
        foreach (string code in allCodes) {
            if (!s.Contains(code)) return false;
        }
        return true;
    }

    private void Backtrack(int n, string path, HashSet<string> result) {
        if (path.Length == n) {
            result.Add(path);
            return;
        }
        Backtrack(n, path + "0", result);
        Backtrack(n, path + "1", result);
    }
}