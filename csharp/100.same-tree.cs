/*
 * @lc app=leetcode id=100 lang=csharp
 *
 * [100] Same Tree
 */

// @lc code=start
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
    public bool IsSameTree(TreeNode p, TreeNode q) 
    {
        if (p == null && q == null)
        {
            return true;
        }
        else if (p == null && q != null)
        {
            return false;
        }
        else if (p != null && q == null)
        {
            return false;
        }
        else 
        {
            return p.val == q.val 
                && this.IsSameTree(p.left, q.left) 
                && this.IsSameTree(p.right, q.right);
        }
    }
}
// @lc code=end

