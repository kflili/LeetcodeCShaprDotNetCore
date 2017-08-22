// recursion
public class Solution {
    public IList<int> InorderTraversal(TreeNode root) {
        var res = new List<int>();
        helper(root, res);
        return res;
    }
    private void helper(TreeNode root, List<int> res) {
        if (root != null) {
            helper(root.left, res);
            res.Add(root.val);
            helper(root.right, res);
        }
    }
}

// iteration
public class Solution {
    public IList<int> InorderTraversal(TreeNode root) {
        var list = new List<int>();
        Stack<TreeNode> stack = new Stack<TreeNode>();
        TreeNode cur = root;
        while (cur != null || stack.Count > 0) {
            while (cur != null) {
                stack.Push(cur);
                cur = cur.left;
            }
            cur = stack.Pop();
            list.Add(cur.val);
            cur = cur.right;
        }
        return list;
    }
}