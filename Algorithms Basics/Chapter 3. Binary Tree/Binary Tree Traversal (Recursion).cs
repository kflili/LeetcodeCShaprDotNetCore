public class Solution {
    // Pre-order
    public IList<int> PreorderTraversal(TreeNode root) {
        var res = new List<int>();
        if (root == null) return res;
        res.Add(root.val);
        if (root.left != null){
            res.AddRange(PreorderTraversal(root.left));
        }
        if (root.right != null) {
            res.AddRange(PreorderTraversal(root.right));
        }
        return res;
    }

    // In-order
    public IList<int> InorderTraversal(TreeNode root) {
        var res = new List<int>();
        if (root == null) return res;
        if (root.left != null) {
            res.AddRange(InorderTraversal(root.left));
        }
        res.Add(root.val);
        if (root.right != null) {
            res.AddRange(InorderTraversal(root.right));
        }
        return res;
    }

    // Post-order
    public IList<int> PostorderTraversal(TreeNode root) {
        var res = new List<int>();
        if (root == null) return res;
        if (root.left != null) {
            res.AddRange(PostorderTraversal(root.left));
        }
        if (root.right != null) {
            res.AddRange(PostorderTraversal(root.right));
        }
        res.Add(root.val);
        return res;
    }
}