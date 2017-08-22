public class Solution {
    public IList<string> BinaryTreePaths(TreeNode root) {
        IList<string> res = new List<string>();
        if (root == null) return res;
        if (root.left == null && root.right == null) {
            res.Add(root.val.ToString());
            return res;
        }
        var leftPaths = BinaryTreePaths(root.left);
        var rightPaths = BinaryTreePaths(root.right);
        if (leftPaths != null) {
            foreach (var path in leftPaths) {
                var newPath = root.val + "->" + path;
                res.Add(newPath);
            }
        }
        if (rightPaths != null) {
            foreach (var path in rightPaths)
            {
                var newPath = root.val + "->" + path;
                res.Add(newPath);
            }
        }
        return res;
    }
}