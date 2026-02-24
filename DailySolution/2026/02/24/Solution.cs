namespace LeetCodeDaily.Solution24022026;

/**
 * Definition for a binary tree node.
 */
public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class Solution {
    public int count = 0;
    public int SumRootToLeaf(TreeNode root) {
        SumRootToLeaf2(root);
        return count;
    }

    private void SumRootToLeaf2(TreeNode root) {
        if (root.left == null && root.right == null) {
            count += root.val;
        }
        if (root.left != null) {
            var left = root.left;
            int val = root.val * 2 + left.val;
            left.val = val;
            SumRootToLeaf2(left);
        }
        if (root.right != null) {
            var right = root.right;
            int val = root.val * 2 + right.val;
            right.val = val;
            SumRootToLeaf2(right);
        }
    }
}