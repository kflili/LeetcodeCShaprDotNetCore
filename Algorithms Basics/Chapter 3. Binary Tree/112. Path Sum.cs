// recursion
public class Solution {
    public bool HasPathSum(TreeNode root, int sum) {
        if (root == null) return false;
        if (root.left == null && root.right == null && root.val == sum) return true;
        return HasPathSum(root.left, sum - root.val) || HasPathSum(root.right, sum - root.val);
    }
}

// iteration pre-order
public class Solution {
    public bool HasPathSum(TreeNode root, int sum) {
        if (root == null) return false;
        Stack<TreeNode> stack = new Stack<TreeNode>();
        Stack<int> sums = new Stack<int>();
        stack.Push(root);
        sums.Push(sum);
        while (stack.Count > 0) {
            int value = sums.Pop();
            TreeNode top = stack.Pop();
            if (top.left == null && top.right == null && top.val == value) {
                return true;
            }
            if (top.right != null) {
                stack.Push(top.right);
                sums.Push(value - top.val);
            }
            if (top.left != null) {
                stack.Push(top.left);
                sums.Push(value - top.val);
            }
        }
        return false;
    }
}
