namespace DailySolution20260713;

public class Solution {
    public IList<int> SequentialDigits(int low, int high) {
        List<int> a = new List<int>();
        for (int i = 1; i <= 9; i++) {
            GenerateSequentialDigits(i, i + 1, low, high, a);
        }
        a.Sort();
        return a;
    }

    private void GenerateSequentialDigits(int current, int nextDigit, int low, int high, List<int> result) {
        if (current >= low && current <= high) {
            result.Add(current);
        }
        if (nextDigit > 9 || current > high) {
            return;
        }
        GenerateSequentialDigits(current * 10 + nextDigit, nextDigit + 1, low, high, result);
    }
}