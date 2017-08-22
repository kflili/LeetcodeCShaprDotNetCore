public class Solution {
    public IList<string> BinaryTreePaths(TreeNode root) {
        IList<string> paths = new List<string>();
        if (root == null) return paths;
        if (root.left == null && root.right == null) {
            paths.Add(root.val.ToString());
            return paths;
        }
        foreach (var path in BinaryTreePaths(root.left)) {
            var newPath = root.val + "->" + path;
            paths.Add(newPath);
        }
        foreach (var path in BinaryTreePaths(root.right)) {
            var newPath = root.val + "->" + path;
            paths.Add(newPath);
        }
        return paths;
    }
}