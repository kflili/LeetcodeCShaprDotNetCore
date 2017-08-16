class Solution {
    public ListNode RemoveElements(ListNode head, int val) {
        var dummy = new ListNode(0) {next = head};
        var pre = dummy;
        while (head != null) {
            if (head.val == val) {
                pre.next = head.next;
                head = head.next;
            }
            else {
                pre = pre.next;
                head = head.next;
            }
        }
        return dummy.next;
    }
}