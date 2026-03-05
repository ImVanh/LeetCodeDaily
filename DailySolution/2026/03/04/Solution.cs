using System.Runtime.ExceptionServices;

namespace LeetCodeDaily20260304;
public class Solution
{
    public int NumSpecial(int[][] mat) {
        int width = mat.Length;
        int height = mat[0].Length;
        int[] count1 = new int[width];
        int[] count2 = new int[height];
        for (int i = 0; i < width; i++)
        {
            int sum = 0;
            for (int j = 0; j < height; j++)
            {
                sum += mat[i][j];
            }
            count1[i] = sum;
        }

        for (int i = 0; i < height; i++)
        {
            int sum = 0;
            for (int j = 0; j < width; j++)
            {
                sum += mat[j][i];
            }
            count2[i] = sum;
        }

        int res = 0;
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                if (count1[i] + count2[j] == 1) res++;
            }
        }
        return res;
    }
}