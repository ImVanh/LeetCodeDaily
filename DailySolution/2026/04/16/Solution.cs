using System.Diagnostics.Contracts;

namespace LeetCodeDaily20260416;

public class Solution {
    public IList<int> SolveQueries(int[] nums, int[] queries) {
        int size = nums.Length;
        int[] counts = new int[100001];
        Node[] nodes = new Node[size];
        for (int i = 0; i < size; i++) {
            counts[nums[i]]++;
            nodes[i] = new Node() { Value = nums[i], indexLeft = -1, indexRight = -1 };
        }

        // FindIndexLeft and FindIndexRight
        int[] indexs = new int[100001];
        for (int i = 0; i < size; i++)
        {
            if (nodes[i].indexLeft == -1)
            {
                nodes[i].indexLeft = i;
            }
            nodes[i].indexRight = i;
        }
        var result = new List<int>();
        foreach (var query in queries) {
            int count = 0;
            foreach (var num in nums) {
                if (num == query) count++;
            }
            result.Add(count);
        }
        return result;
    }
}

public class Node
{
    public int Value { get; set; }
    public int indexLeft { get; set; }
    public int indexRight { get; set; }
}