namespace DailySolutionLeetCode20260629;
public class Solution {
    public int NumOfStrings(string[] patterns, string word) {
        int count = 0;
        foreach (var pattern in patterns) {
            if (word.Contains(pattern)) {
                count++;
            }
        }
        return count;
    }
}