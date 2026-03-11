namespace LeetCodeDaily20260311;
public class Solution
{
    public int BitwiseComplement(int n)
    {
        if (n == 0)
        {
            return 1;
        }
        int mask = 1;
        while (mask <= n)
        {
            mask <<= 1;
        }
        return mask - 1 - n;
    }

    // Explanation:
    // 1. If n is 0, its binary representation is "0", and
    //    the bitwise complement is "1", which is 1 in decimal.
    // 2. We initialize a mask to 1 and left shift it until it is greater than n. This gives us a mask that has a single bit set just above the highest bit of n.
    // 3. The bitwise complement of n can be calculated as (mask - 1 - n). The expression (mask - 1) creates a number that has all bits set to 1 below the highest bit of n.
}