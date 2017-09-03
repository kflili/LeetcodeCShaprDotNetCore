using System;
using System.Collections.Generic;
using System.Text;


namespace LeetcodeCShaprDotNetCore {
    public class Solution {
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
            if (root.val > p.val && root.val > q.val) {
                return LowestCommonAncestor(root.left, p, q);
            } else if (root.val < p.val && root.val < q.val) {
                return LowestCommonAncestor(root.right, p, q);
            } else {
                return root;
            }
        }
    }
}