namespace LeetCodeDaily20260525;

public class Solution
{
    public bool CanReach(string s, int minJump, int maxJump)
    {
        //Prepare dictionary for quick lookup
        Dictionary<int, bool> memo = new Dictionary<int, bool>();
        return CanReachHelper(s, minJump, maxJump, 0, memo);
    }

    private bool CanReachHelper(string s, int minJump, int maxJump, int position, Dictionary<int, bool> memo)
    {
        if (position == s.Length - 1) return true;
        if (position >= s.Length || s[position] == '0') return false;
        if (memo.ContainsKey(position)) return memo[position];

        for (int jump = minJump; jump <= maxJump; jump++)
        {
            if (CanReachHelper(s, minJump, maxJump, position + jump, memo))
            {
                memo[position] = true;
                return true;
            }
        }

        memo[position] = false;
        return false;
    }
}