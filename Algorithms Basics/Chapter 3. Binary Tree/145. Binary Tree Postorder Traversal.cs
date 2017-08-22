// recursion
public class Solution {
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

// iteration
public class Solution {
    public IList<int> PostorderTraversal(TreeNode root) {
        var res = new List<int>();
        if (root == null) return res;
        Stack<TreeNode> stack = new Stack<TreeNode>();
        stack.Push(root);
        while (stack.Count > 0) {
            root = stack.Pop();
            res.Insert(0, root.val);
            if (root.left != null) stack.Push(root.left);
            if (root.right != null) stack.Push(root.right);
        }
        return res;
    }
}