/*
The the basic idea is to take the last element in postorder array as the root,
 find the position of the root in the inorder array; then locate the range for 
 left sub-tree and right sub-tree and do recursion. 
 Use a HashMap to record the index of root in the inorder array.
 */
public class Solution {
    public TreeNode BuildTree(int[] inorder, int[] postorder) {
        if (inorder == null || postorder == null || inorder.Length != postorder.Length)
            return null;
        Dictionary<int, int> inMap = new Dictionary<int, int>();
        for (int i = 0; i < inorder.Length; ++i)
            inMap.Add(inorder[i], i);
        return BuildTreePostIn(inorder, 0, inorder.Length - 1, postorder, 0,
                                postorder.Length - 1, inMap);
    }

    private TreeNode BuildTreePostIn(int[] inorder, int inStart, int inEnd, int[] postorder, int postStart, int postEnd,
                                        Dictionary<int, int> inMap) {
        if (postStart > postEnd || inStart> inEnd) return null;
        TreeNode root = new TreeNode(postorder[postEnd]);

        int inRoot = inMap[postorder[postEnd]];
        int leftTreeLen = inRoot - inStart;

        root.left = BuildTreePostIn(inorder, inStart, inRoot - 1, postorder, postStart, postStart + leftTreeLen -1, inMap);
        root.right = BuildTreePostIn(inorder, inRoot + 1, inEnd, postorder, postStart + leftTreeLen, postEnd - 1, inMap);
        return root;
    }
}