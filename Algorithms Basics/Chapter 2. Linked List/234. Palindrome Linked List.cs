public class Solution {
    public bool IsPalindrome(ListNode head) {
        if (head == null || head.next == null) {
            return true;
        }
        // find middle node
        ListNode middle = FindMiddle(head);
        // reverse the second half
        middle.next = Reverse(middle.next);
        // compare the first half and the reversed second half
        ListNode p1 = head, p2 = middle.next;
        while (p1 != null && p2 != null && p1.val == p2.val) {
            p1 = p1.next;
            p2 = p2.next;
        }
        return p2 == null;
    }
    private ListNode FindMiddle(ListNode head) {
        // 1 => 1; 12 => 1; 121 => 2
        ListNode slow = head;
        ListNode fast = head.next;
        while (fast != null && fast.next != null) {
            slow = slow.next;
            fast = fast.next.next;
        }
        return slow;
    }
    private ListNode Reverse(ListNode head) {
        ListNode pre = null;
        ListNode temp = null;
        while (head != null) {
            temp = head.next;
            head.next = pre;
            pre = head;
            head = temp;
        }
        return pre;
    }
}