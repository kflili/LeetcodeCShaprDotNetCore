// A general one for pre- in- post-.
public class Solution {
    // Preorder
    public IList<int> PreorderTraversal(TreeNode root) {
        List<int> result = new List<int>();
        Stack<TreeNode> stack = new Stack<TreeNode>();
        TreeNode p = root;
        while (p != null || stack.Count > 0) {
            if (p != null) {
                result.Add(p.val);  // Add before going to children
                stack.Push(p);
                p = p.left;
            } else {
                TreeNode node = stack.Pop();
                p = node.right;
            }
        }
        return result;
    }
    // Inorder
    public IList<int> InorderTraversal(TreeNode root) {
        List<int> result = new List<int>();
        Stack<TreeNode> stack = new Stack<TreeNode>();
        TreeNode p = root;
        while (p != null || stack.Count > 0) {
            if (p != null) {
                stack.Push(p);
                p = p.left;
            } else {
                TreeNode node = stack.Pop();
                result.Add(node.val);  // Add after all left children
                p = node.right;
            }
        }
        return result;
    }
    // Postorder
    public IList<int> PostorderTraversal(TreeNode root) {
        List<int> result = new List<int>();
        Stack<TreeNode> stack = new Stack<TreeNode>();
        TreeNode p = root;
        while (p != null || stack.Count > 0) {
            if (p != null) {
                result.Insert(0, p.val);    
                stack.Push(p);
                p = p.right;    // Reverse the process of preorder
            } else {
                TreeNode node = stack.Pop();
                p = node.left;
            }
        }
        return result;
    }
    // Postorder2, direct thought without reverse process
    public IList<int> PostorderTraversal(TreeNode root) {
        List<int> result = new List<int>();
        Stack<TreeNode> stack = new Stack<TreeNode>();
        TreeNode p = root;
        TreeNode lastVisit = null;
        while (p != null || stack.Count > 0) {
            if (p != null) {
                stack.Push(p);
                p = p.left;
            } else {
                TreeNode node = stack.Peek();
                if (node.right != null && node.right != lastVisit) {
                    p = node.right;
                } else {
                    result.Add(node.val);
                    lastVisit = node;
                    stack.Pop();
                    p = null;
                }
            }
        }
        return result;
    }
    // level order
    public IList<IList<int>> LevelOrder(TreeNode root) {
        List<IList<int>> result = new List<IList<int>>();
        if (root == null) return result;
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while (queue.Count > 0) {
            List<int> level = new List<int>();
            int size = queue.Count;
            while (size-- > 0) {
                TreeNode head = queue.Dequeue();
                level.Add(head.val);
                if (head.left != null) queue.Enqueue(head.left);
                if (head.right != null) queue.Enqueue(head.right);
            }
            result.Add(level);
        }
        return result;
    } 
}