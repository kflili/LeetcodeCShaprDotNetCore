// recursion
public class Solution {
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