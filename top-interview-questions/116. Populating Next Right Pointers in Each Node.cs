// iteration: for each level, scan from left to right
public class Solution {
    public void Connect(TreeLinkNode root) {
        TreeLinkNode levelStart = root;
        while (levelStart != null) {
            TreeLinkNode p = levelStart;
            while (p != null) {
                if (p.left != null) {
                    p.left.next = p.right;
                }
                if (p.right != null) {
                    p.right.next = (p.next == null) ? null : p.next.left;
                }
                p = p.next;
            }
            levelStart = levelStart.left;  // next level begin from the left
        }
    }
}
// recursion:
public class Solution {
    public void Connect(TreeLinkNode root) {
        if (root == null) return;
        if (root.left != null) {
            root.left.next = root.right;  // perfect BT, mush have right if has left
            if (root.next != null) {
                root.right.next = root.next.left;  // same reason as above
            }
        }
        connect(root.left);
        connect(root.right); 
    }
}