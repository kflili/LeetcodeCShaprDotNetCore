// recursion
public class Solution {
    public bool IsSymmetric(TreeNode root) {
        return IsMirror(root, root);
    }
    private bool IsMirror(TreeNode t1, TreeNode t2) {
        if (t1 == null && t2 == null) return true;
        if (t1 == null || t2 == null) return false;
        return (t1.val == t2.val)
            && IsMirror(t1.left, t2.right)
            && IsMirror(t1.right, t2.left);
    }
}

// iteration
public class Solution {
    public bool IsSymmetric(TreeNode root) {
        Queue<TreeNode> q = new Queue<TreeNode>();
        q.Enqueue(root);
        q.Enqueue(root);
        while (q.Count > 0) {
            TreeNode t1 = q.Dequeue();
            TreeNode t2 = q.Dequeue();
            if (t1 == null && t2 == null) continue;
            if (t1 == null || t2 == null) return false;
            if (t1.val != t2.val) return false;
            q.Enqueue(t1.left);
            q.Enqueue(t2.right);
            q.Enqueue(t1.right);
            q.Enqueue(t2.left);
        }
        return true;
    }
}