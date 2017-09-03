// general one for BT not only BST
public class Solution {
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        if (root == null) return null;
        if (root == p || root == q) return root;
        TreeNode left = LowestCommonAncestor(root.left, p, q);
        TreeNode right = LowestCommonAncestor(root.right, p, q);
        if (left != null && right != null) return root;
        return left == null ? right : left;
    }
}

// specific for BST
public class Solution {
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        if (root.val > p.val && root.val > q.val) {
            return LowestCommonAncestor(root.left, p, q);
        } else if (root.val < p.val && root.val < q.val) {
            return LowestCommonAncestor(root.right, p, q);
        } else {
            return root;
        }
    }
}