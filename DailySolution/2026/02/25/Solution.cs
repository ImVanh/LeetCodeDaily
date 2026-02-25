namespace LeetCodeDaily.Solution25022026;

public class Solution {
    public int[] SortByBits(int[] arr) {
        Array.Sort(arr, (a, b) =>
        {
            int numBitOneA = CountBitOne(a);
            int numBitOneB = CountBitOne(b);

            if (numBitOneA < numBitOneB) return -1;
            if (numBitOneA > numBitOneB) return 1;
            if (a == b) return 0;
            if (a < b) return -1;
            return 1;
        });
        return arr;
    }

    private int CountBitOne(int n) {
        int res = 0;
        while (n > 0) {
            if (n % 2 == 1) res++;
            n = n / 2;
        }
        return res;    
    }
}