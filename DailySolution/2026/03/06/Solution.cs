namespace LeetCodeDaily20260306;
public class Solution
{
    public bool CheckOnesSegment(string s) {
        if (s.Length < 3) return true;
        bool flag1 = false;
        bool flag2 = false;
        for (int i = 1; i < s.Length - 1; i++) {
            if (s[i] == '0' && s[i - 1] == '1')
            {
                flag1 = true;
            }
            if (s[i] == '0' && s[i + 1] == '1')
            {
                flag2 = true;
            }
        }
        if (flag1 && flag2) return false;
        return true;
    }
}