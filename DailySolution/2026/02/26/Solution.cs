namespace LeetCodeDaily.Solution26022026;

public class Solution {
    public int NumSteps(string s) {
        List<char> temp = new List<char>();
        for (int i = s.Length - 1; i >= 0; i--) {
            temp.Add(s[i]);
        }
        return ReduceNumber(temp, 0, 0);
    }

    private int ReduceNumber(List<char> temp, int current, int step) {
        // Console.WriteLine(current + " - " + step);
        // foreach(var ch in temp) {
        //     Console.Write(ch + " ");
        // }
        // Console.WriteLine();
        if (current == temp.Count - 1 && temp[current] == '1') {
            return step;
        }
        if (temp[current] == '0') {
            return ReduceNumber(temp, current + 1, step + 1);
        } else {
            bool flag = true;
            for (int i = current; i < temp.Count; i++) {
                if (temp[i] == '1' && flag) {
                    temp[i] = '0';
                } else {
                    flag = false;
                    temp[i] = '1';
                    break;
                }
            }
            if (flag) {
                temp.Add('1');
            }
            return ReduceNumber(temp, current, step + 1);
        }
    }

}