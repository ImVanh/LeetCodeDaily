namespace LeetCodeDaily20260327;
public class Solution
{
    public bool AreSimilar(int[][] mat, int k)
    {
        int height = mat.Length;
        int width = mat[0].Length;
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                int nextIndex = (j + k) % width;
                if (mat[i][j] != mat[i][nextIndex])
                {
                    return false;
                }
            }
        }
        return true;
    }
}