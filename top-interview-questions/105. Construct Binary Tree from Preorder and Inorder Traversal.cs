/*
first find the root form preorder[0], then find the index of root in inorder[].
then we can divide the inorder into left subtree and right subtree.
 */
public class Solution {
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        if (preorder.Length != inorder.Length) return null;
        return build(preorder, 0, preorder.Length - 1, inorder, 0, inorder.Length - 1);
    }

    public TreeNode build(int[] preorder, int preLow, int preHigh, int[] inorder, int inLow, int inHigh) {
        if (preLow > preHigh || inLow > inHigh) return null;
        TreeNode root = new TreeNode(preorder[preLow]);

        int inorderRoot = inLow;
        for (int i = inLow; i <= inHigh; i++) {
            if (inorder[i] == root.val) { inorderRoot = i; break; }
        }

        int leftTreeLen = inorderRoot - inLow;
        root.left = build(preorder, preLow + 1, preLow + leftTreeLen, inorder, inLow, inorderRoot - 1);
        root.right = build(preorder, preLow + leftTreeLen + 1, preHigh, inorder, inorderRoot + 1, preHigh);
        return root;
    }
}

// use Dictionary improve the runtime
public class Solution {
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        Dictionary<int, int> inMap = new Dictionary<int, int>();

        for (int i = 0; i < inorder.Length; i++) {
            inMap.Add(inorder[i], i);
        }

        TreeNode root = BuildTree(preorder, 0, preorder.Length - 1, inorder, 0, inorder.Length - 1, inMap);
        return root;
    }

    public TreeNode BuildTree(int[] preorder, int preStart, int preEnd, int[] inorder, int inStart, int inEnd, Dictionary<int, int> inMap) {
        if (preStart > preEnd || inStart > inEnd) return null;

        TreeNode root = new TreeNode(preorder[preStart]);
        int inRoot = inMap[root.val];
        int leftTreeLen = inRoot - inStart;

        root.left = BuildTree(preorder, preStart + 1, preStart + leftTreeLen, inorder, inStart, inRoot - 1, inMap);
        root.right = BuildTree(preorder, preStart + leftTreeLen + 1, preEnd, inorder, inRoot + 1, inEnd, inMap);

        return root;
    }
}