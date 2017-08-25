public class Solution {
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