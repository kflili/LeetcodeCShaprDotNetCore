public class Solution {
    public ListNode ReverseList(ListNode head) {
        ListNode pre = null, temp = null;
        while (head != null) {
            temp = head.next;
            head.next = pre;
            pre = head;
            head = temp;
        }
        return pre;
    }
}