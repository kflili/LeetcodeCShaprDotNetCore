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

// iteration1: reverse order insert, similar to two stack.
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

// two stack
public class Solution {
    public IList<int> PostorderTraversal(TreeNode root) {
        var res = new List<int>();
        if (root == null) return res;
        // Create two stacks
        var s1 = new Stack<TreeNode>();
        var s2 = new Stack<TreeNode>();
        // push root to first stack
        s1.Push(root);
        // Run while first stack is not empty
        while (s1.Count > 0) {
            // Pop an item from s1 and push it to s2
            var temp = s1.Pop();
            s2.Push(temp);
            // Push left and right children of removed
            // item to s1
            if (temp.left != null) s1.Push(temp.left);
            if (temp.right != null) s1.Push(temp.right);
        }
        // record all itmes in second stack
        while (s2.Count > 0) {
            var node = s2.Pop();
            res.Add(node.val);
        }
        return res;
    }
}
// straightforward just like virtually traverse in postorder
public class Solution {
    public IList<int> PostorderTraversal(TreeNode root) {
        var res = new List<int>();
        if (root == null) return res;
        var stack = new Stack<TreeNode>();
        TreeNode lastVisit = null;
        while (root != null || stack.Count > 0) {
            while (root != null) {
                stack.Push(root);
                root = root.left;
            }
            root = stack.Peek();
            // if root.right == null, then root is leaf, just Add root
            // if root.right == lastVisit, 
            // then both left and right are visited, just Add root
            if (root.right == null || root.right == lastVisit) {
                res.Add(root.val);
                // pop root, mark it as lastvisit, and let root = null,
                // so we can keep going to peek stack top for next step
                stack.Pop();
                lastVisit = root;
                root = null;
            } else {
                // root.right not null, and it's not visited
                root = root.right;
            }
        }
        return res;
    }
}