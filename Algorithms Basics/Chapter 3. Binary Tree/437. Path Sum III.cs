public class Solution {
    public int PathSum(TreeNode root, int sum) {
        if (root == null) return 0;
        return PathSumFrom(root, sum) + PathSum(root.left, sum) + PathSum(root.right, sum);
    }
    private int PathSumFrom(TreeNode node, int sum) {
        if (node == null) return 0;
        if (node.val == sum) {
            return 1 + PathSumFrom(node.left, 0) + PathSumFrom(node.right, 0);
        } else {
            return PathSumFrom(node.left, sum - node.val) 
                    + PathSumFrom(node.right, sum - node.val);
        }
    }
}