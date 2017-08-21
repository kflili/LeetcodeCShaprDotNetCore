// recursion
public class Solution {
    public int MaxDepth(TreeNode root) {
        if (root == null) return 0;
        return 1 + Math.Max(MaxDepth(root.left), MaxDepth(root.right));
    }
}

// BFS interation
public class SolutionBFS {
    public int MaxDepth(TreeNode root) {
        if (root == null) return 0;
        Queue<TreeNode> q = new Queue<TreeNode>();
        q.Enqueue(root);
        int maxDepth = 0;
        while (q.Count > 0) {
            int size = q.Count;
            while (size-- > 0) {
                TreeNode node = q.Dequeue();
                if (node.left != null) q.Enqueue(node.left);
                if (node.right != null) q.Enqueue(node.right);
            }
            maxDepth++;
        }
        return maxDepth;
    }
}