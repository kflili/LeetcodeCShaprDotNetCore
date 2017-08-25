// recursion
/**
* 利用栈实现循环先序遍历二叉树
* 这种实现类似于图的深度优先遍历（DFS）
* 维护一个栈，将根节点入栈，然后只要栈不为空，出栈并访问，接着依次将访问节点的右节点、左节点入栈。
* 这种方式应该是对先序遍历的一种特殊实现（看上去简单明了），但是不具备很好的扩展性，在中序和后序方式中不适用
*/ 
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

/* 
* 利用栈模拟递归过程实现循环先序遍历二叉树
* 这种方式具备扩展性，它模拟递归的过程，将左子树点不断的压入栈，直到null，然后处理栈顶节点的右子树
*/
public class Solution {
    public IList<int> PreorderTraversal(TreeNode root) {
        var res = new List<int>();
        if (root == null) return res;
        Stack<TreeNode> stack = new Stack<TreeNode>();
        while (root != null || stack.Count > 0) {
            while (root != null) {
                res.Add(root.val);
                stack.Push(root);
                root = root.left;
            }
            root = stack.Pop();
            root = root.right;
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