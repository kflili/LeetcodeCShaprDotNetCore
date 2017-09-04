// use queue do bfs, use list.insert(0, val) to reverse insert order for backwords.
public class Solution {
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root) {
        IList<IList<int>> result = new List<IList<int>>();
        if (root == null) return result;
        Queue<TreeNode> q = new Queue<TreeNode>();
        q.Enqueue(root);
        bool isForwardOrder = true;
        while(q.Count > 0) {
            IList<int> levelResult = new List<int>();
            int levelSize = q.Count;
            for (int i = 0; i < levelSize; i++) {
                TreeNode node = q.Dequeue();
                if (isForwardOrder) {
                    levelResult.Add(node.val);
                } else {
                    // if backword order, reverse insert order
                    levelResult.Insert(0, node.val);
                }
                if (node.left != null) q.Enqueue(node.left);
                if (node.right != null) q.Enqueue(node.right);
            }
            // record level result
            result.Add(levelResult);
            // change direction flag
            isForwardOrder = !isForwardOrder;
        }
        return result;
    }
}

// two stack method, use a direction flag.
public class Solution {
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root) {
        IList<IList<int>> result = new List<IList<int>>();
        if (root == null) return result;
        Stack<TreeNode> currLevel = new Stack<TreeNode>();
        Stack<TreeNode> nextLevel = new Stack<TreeNode>();
        currLevel.Push(root);
        bool isForwardOrder = true;
        while (currLevel.Count > 0) {
            IList<int> currLevelResult = new List<int>();
            while (currLevel.Count > 0) {
                TreeNode node = currLevel.Pop();
                currLevelResult.Add(node.val);
                if (isForwardOrder) {
                    if (node.left != null) nextLevel.Push(node.left);
                    if (node.right != null) nextLevel.Push(node.right);
                } else {
                    if (node.right != null) nextLevel.Push(node.right); 
                    if (node.left != null) nextLevel.Push(node.left);
                }
            }
            // save current level result
            result.Add(currLevelResult);
            // swich currlevel and nextlevel
            var temp = currLevel;
            currLevel = nextLevel;
            nextLevel = temp;
            // rest direction flag
            isForwardOrder = !isForwardOrder;
        }
        return result;
    }
}