// HashSet + recursion traverse
public class Solution {
    HashSet<int> set = new HashSet<int>();
    public bool FindTarget(TreeNode root, int k) {
        if (root == null) {
            return false;
        }
        if (set.Contains(k - root.val)) {
            return true;
        }
        set.Add(root.val);
        return FindTarget(root.left, k) || FindTarget(root.right, k);
    }
}

// BFS + HashSet
public class Solution {
    public bool FindTarget(TreeNode root, int k) {
        if (root == null) {
            return false;
        }
        HashSet<int> set = new HashSet<int>();
        Queue<TreeNode> q = new Queue<TreeNode>();
        q.Enqueue(root);
        while (q.Count != 0) {
            var node = q.Dequeue();
            if (set.Contains(k - node.val)) {
                return true;
            }
            set.Add(node.val);
            if (node.left != null) q.Enqueue(node.left);
            if (node.right != null) q.Enqueue(node.right);
        }
        return false;
    }
}

// use the feature of BST, flatten it into ordered list.
// then use two pointer.
public class Solution {
    public bool FindTarget(TreeNode root, int k) {
        if (root == null) 
            return false;
        var list = new List<int>();
        TreeToList(root, list);
        for (int l = 0, r = list.Count - 1; l < r;) {
            int sum = list[l] + list[r];
            if (sum == k) 
                return true;
            if (sum < k) 
                l++;
            else 
                r--;
        }
        return false;
    }
    private void TreeToList(TreeNode root, List<int> list) {
        if (root == null) 
            return;
        TreeToList(root.left, list);
        list.Add(root.val);
        TreeToList(root.right, list);
    }
}