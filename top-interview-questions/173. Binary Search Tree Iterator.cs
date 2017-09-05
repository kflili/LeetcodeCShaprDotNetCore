/*
beacuse we want to keep track for all small node, so use stack to save all
the left child. when call next() to return left bottom child. 
At the same time, we need push it's right child to stack.
 */
public class BSTIterator {
    private Stack<TreeNode> stack = new Stack<TreeNode>();
    private void PushNodeToStack(TreeNode root) {
        while (root != null) {
            stack.Push(root);
            root = root.left;
        }
    }

    public BSTIterator(TreeNode root) {
        PushNodeToStack(root);
    }

    /** @return whether we have a next smallest number */
    public bool HasNext() {
        return stack.Count > 0;
    }

    /** @return the next smallest number */
    public int Next() {
        TreeNode cur = stack.Pop();
        PushNodeToStack(cur.right);
        return cur.val;
    }
}

/**
* Your BSTIterator will be called like this:
* BSTIterator i = new BSTIterator(root);
* while (i.HasNext()) v[f()] = i.Next();
*/