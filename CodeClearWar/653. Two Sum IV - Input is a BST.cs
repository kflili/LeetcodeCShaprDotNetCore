public class Solution {
    // 1 BFS and HashSet, iteration
    public bool FindTarget(TreeNode root, int k) {
        if (root == null) return false;
        var set = new HashSet<int>();
        var q = new Queue<TreeNode>();
        q.Enqueue(root);
        while (q.Count > 0) {
            var node = q.Dequeue();
            var complement = k - node.val;
            if (set.Contains(complement)) {
                return true;
            }
            set.Add(node.val);
            if (node.left != null) q.Enqueue(node.left);
            if (node.right != null) q.Enqueue(node.right);
        }
        return false;
    }

    // 2 just HashSet, recursive
    public bool FindTarget(TreeNode root, int k) {
        var set = new HashSet<int>();
        return Find(root, k, set);
    }
    private bool Find(TreeNode root, int k, HashSet<int> set) {
        if (root == null) return false;
        var complement = k - root.val;
        if (set.Contains(complement)) return true;
        set.Add(root.val);
        return Find(root.left, k, set) || Find(root.right, k, set);
    }

    // 3 Transfer BST to ordering list, then use two pointers to do the twoSum
    public bool FindTarget(TreeNode root, int k) {
        if (root == null) return false;
        var list = new List<int>();
        InOrderTranverse(root, list);
        for (int i = 0, j = list.Count - 1; i < j;) {
            var v = list[i] + list[j];
            if (v == k) return true;
            else if (v < k) i++;
            else j--;
        }
        return false;
    }
    private void InOrderTranverse(TreeNode root, List<int> list) {
        if (root.left != null) InOrderTranverse(root.left, list);
        list.Add(root.val);
        if (root.right != null) InOrderTranverse(root.right, list);
    }
}

/*
Next challenges:
Serialize and Deserialize BST
Maximum Binary Tree
Print Binary Tree
 */