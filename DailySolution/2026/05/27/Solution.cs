namespace LeetCodeDaily20260527;

public class Solution {
    public int NumberOfSpecialChars(string word) {
        int dif = 'a' - 'A';
        int[] counts = new int[('z' + 1)];
        bool[] visited = new bool[('z' + 1)];
        int[] lastApp = new int[('z' + 1)];
        int[] lastApp2 = new int[('z' + 1)];

        for(int i = 0; i < word.Length; i++) {
            counts[word[i]] ++;
            lastApp[word[i]] = i;
        }

        for (int i = word.Length - 1; i >= 0; i--) {
            lastApp2[word[i]] = i;
        }

        int count = 0;

        for(int i = 0; i < word.Length; i++) {
            int under = word[i] - dif;
            // System.Console.WriteLine(under);
            if (counts[under] != 0 && !visited[under]) {
                visited[under] = true;
                if (lastApp[word[i]] < lastApp2[under]) {
                    count ++;
                }
            }
        }
        return count;
    }
}