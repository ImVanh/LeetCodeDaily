namespace DailySolution20260819;

public class Solution {
    public int MaxNumberOfFamilies(int n, int[][] reservedSeats) {
        //
        Dictionary<int, List<int>> reservedMap = new Dictionary<int, List<int>>();
        foreach (var seat in reservedSeats) {
            int row = seat[0];
            int col = seat[1];
            if (!reservedMap.ContainsKey(row)) {
                reservedMap[row] = new List<int>();
            }
            reservedMap[row].Add(col);
        }

        int count = 0;

        for (int i = 0; i < n; i++) {
            var row = new bool[10];
            var reversedRow = reservedMap.ContainsKey(i + 1) ? reservedMap[i + 1] : new List<int>();
            foreach (var num in reversedRow) {
                row[num] = true;
            }
            count += numOfPlaceFamily(row);

        }
        return count;
    }

    private int numOfPlaceFamily(bool[] row) {
        int count = 0;
        bool placeFirst = CanPlaceFirstFamily(row, 1, 4);
        bool placeSecond = CanPlaceFirstFamily(row, 3, 6);
        bool placeThird = CanPlaceFirstFamily(row, 5, 8);
        
        if (placeFirst && placeSecond)
        {
            placeSecond = false;
        }

        if (placeSecond && placeThird)
        {
            placeSecond = false;
        }

        if (placeFirst) count++;
        if (placeSecond) count++;
        if (placeThird) count++;

        return count;
    }

    private bool CanPlaceFirstFamily(bool[] row, int from, int to) {
        for (int i = from; i <= to; i++) {
            if (row[i]) {
                return false;
            }
        }
        return true;
    }
}