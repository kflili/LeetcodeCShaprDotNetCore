// consise but not direct thought
public class Solution {
    public bool IsValidBST(TreeNode root) {
        // use long.min or max just because we want absolute min and max value
        // to pass corner case that node has int.min or int.max
        return CheckEachNode(root, long.MinValue, long.MaxValue);
    }
    // make sure each node's val is in right range.
    private bool CheckEachNode(TreeNode node, long minVal, long maxVal) {
        if (node == null) return true;
        if (node.val <= minVal || node.val >= maxVal) return false;
        return CheckEachNode(node.left, minVal, node.val) 
                && CheckEachNode(node.right, node.val, maxVal);
    }
}

// use Return Type, may easy to come up idea from problem description
public class Solution {
    public bool IsValidBST(TreeNode root) {
        var res = helper(root);
        return res.IsValid;
    }
    public class ResultType {
        public ResultType(bool state, int max, int min) {
            IsValid = state;
            MaxValue = max;
            MinValue = min;
        }
        public bool IsValid { get; set; }
        public int MaxValue { get; set; }
        public int MinValue { get; set; }

    }
    private ResultType helper(TreeNode root) {
        if (root == null) {
            return new ResultType(true, 0, 0);
        }
        ResultType res = new ResultType(true, root.val, root.val);
        if (root.left == null && root.right == null) {
            return res;
        }
        if (root.left != null) {
            var left = helper(root.left);
            if (!left.IsValid || left.MaxValue >= root.val) {
                return new ResultType(false, 0, 0);
            }
            res.MinValue = left.MinValue;
        }
        if (root.right != null) {
            var right = helper(root.right);
            if (!right.IsValid || right.MinValue <= root.val) {
                return new ResultType(false, 0, 0);
            }
            res.MaxValue = right.MaxValue;
        }
        return res;
    }
}