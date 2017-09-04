public class Solution {
    public void Connect(TreeLinkNode root) {
        TreeLinkNode leftStart = null;  // left start of next level, the enter point for going down
        TreeLinkNode prev = null;  // leading node on the next level
        TreeLinkNode cur = root;  // current node of current level
        while (cur != null) {
            while (cur != null) {
                if (cur.left != null) {
                    // check prev, if prev exists, then connect
                    if (prev != null) {
                        prev.next = cur.left;
                    } else {
                    // if no prev, that means not yet visit on next level, so need assign leftstart
                        leftStart = cur.left;
                    }
                    // update prev either for moving or assign with leftStart together
                    prev = cur.left;
                }
                if (cur.right != null) {
                    if (prev != null) {
                        prev.next = cur.right;
                    } else {
                        leftStart = cur.right;
                    }
                    prev = cur.right;
                }
                cur = cur.next;
            }
            cur = leftStart;
            leftStart = null;
            prev = null;
        }
    }
}