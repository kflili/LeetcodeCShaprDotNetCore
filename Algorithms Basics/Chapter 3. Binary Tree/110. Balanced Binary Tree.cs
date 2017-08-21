// easy thought, worse complexity O(n^2)
// for node,
// 1, we need first visit the left and right to get MaxDepth, 
// 2, visit left and right to check if left and right both are balanced.
// so visit each node twice. therefore O(n^2);
public class Solution {
    public bool IsBalanced(TreeNode root) {
        if (root == null) return true;
        int left = MaxDepth(root.left);
        int right = MaxDepth(root.right);
        return Math.Abs(left - right) <= 1 && IsBalanced(root.left) && IsBalanced(root.right);
    }
    private int MaxDepth(TreeNode root) {
        if (root == null) return 0;
        return 1 + Math.Max(MaxDepth(root.left), MaxDepth(root.right));
    }
}

// for each node,
// 1, check the left and right MaxDepth,
// 2, if MaxDepth == -1, just return -1; else return MaxDepth + 1;
// so just visit every node once. therefore O(n);
public class Solution2 {
        public bool IsBalanced(TreeNode root) {
            return MaxDepth(root) != -1;
        }
        private int MaxDepth(TreeNode root) {
            if (root == null) return 0;
            int left = MaxDepth(root.left);
            if (left == -1) return -1;
            int right = MaxDepth(root.right);
            if (right == -1) return -1;
            if (Math.Abs(left - right) > 1) return -1;
            return Math.Max(left, right) + 1;
        }
    }