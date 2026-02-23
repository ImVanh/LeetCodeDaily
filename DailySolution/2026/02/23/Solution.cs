namespace LeetCodeDaily.Solution2026;
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

// Failed Solution
// Need Improve performance.
// Using Math.Pow(2, k) to calculate the total number of binary codes of length k, and then check if the number of unique substrings of length k in s is equal to that total. This approach is more efficient than generating all possible codes and checking for their presence in s.
// public bool HasAllCodes(string s, int k) {
//     int totalCodes = (int)Math.Pow(2, k);
//     HashSet<string> uniqueSubstrings = new HashSet<string>();
//     for (int i = 0; i <= s.Length - k; i++) {
//         uniqueSubstrings.Add(s.Substring(i, k));
//     }
//     return uniqueSubstrings.Count == totalCodes;
// }