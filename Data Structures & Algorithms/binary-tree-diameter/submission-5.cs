/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    int maxDiameter = 0;
    
    public int DiameterOfBinaryTree(TreeNode root) {
        GetDepth(root);
        return maxDiameter;
    }

    private int GetDepth(TreeNode root) {
        if (root == null) return 0;
        
        int leftDiameter = GetDepth(root.left);
        int rightDiameter = GetDepth(root.right);

        maxDiameter = Math.Max(maxDiameter, leftDiameter + rightDiameter);

        return Math.Max(leftDiameter, rightDiameter) + 1;
    }
}
