public class Solution {
    public IList<IList<int>> LevelOrder(TreeNode root) {
        Queue<TreeNode> queue = new Queue<TreeNode>();
        var result = new List<IList<int>>();
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