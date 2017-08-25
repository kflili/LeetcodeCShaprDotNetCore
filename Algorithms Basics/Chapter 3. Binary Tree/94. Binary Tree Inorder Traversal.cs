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

/**
* 
* @param root 树根节点
* 利用栈模拟递归过程实现循环中序遍历二叉树
* 思想和上面的preOrderStack_2相同，只是访问的时间是在左子树都处理完直到null的时候出栈并访问。
*/
public class Solution {
    public IList<int> InorderTraversal(TreeNode root) {
        var res = new List<int>();
        if (root == null) return res;
        Stack<TreeNode> stack = new Stack<TreeNode>();       
        while (cur != null || stack.Count > 0) {
            while (cur != null) {
                stack.Push(root);
                root = root.left;
            }
            root = stack.Pop();
            res.Add(root.val);
            root = root.right;
        }
        return res;
    }
}