public class Solution {
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        if (root == null) return null;
        if (root == p || root == q) return root;
        TreeNode left = LowestCommonAncestor(root.left, p, q);
        TreeNode right = LowestCommonAncestor(root.right, p, q);
        if (left != null && right != null) return root;
        return left == null ? right : left;
    }
}

// if there are parent for each node, the solution can be changed
public ParentTreeNode lowestCommonAncestorII(ParentTreeNode root,
                                                ParentTreeNode A,
                                                ParentTreeNode B) {
    ArrayList<ParentTreeNode> pathA = getPath2Root(A);
    ArrayList<ParentTreeNode> pathB = getPath2Root(B);
    
    int indexA = pathA.size() - 1;
    int indexB = pathB.size() - 1;
    
    ParentTreeNode lowestAncestor = null;
    while (indexA >= 0 && indexB >= 0) {
        if (pathA.get(indexA) != pathB.get(indexB)) {
            break;
        }
        lowestAncestor = pathA.get(indexA);
        indexA--;
        indexB--;
    }
    
    return lowestAncestor;
}

private ArrayList<ParentTreeNode> getPath2Root(ParentTreeNode node) {
    ArrayList<ParentTreeNode> path = new ArrayList<>();
    while (node != null) {
        path.add(node);
        node = node.parent;
    }
    return path;
}