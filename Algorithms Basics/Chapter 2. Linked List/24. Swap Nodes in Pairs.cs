// iteration
public class Solution {
    public ListNode SwapPairs(ListNode head) {
        if (head == null || head.next == null) return head;
        ListNode dummy = new ListNode(0);
        dummy.next = head;
        ListNode pre = dummy, temp = null;
        while (head != null && head.next != null) {
            ListNode n1 = head, n2 = head.next;
            //       head
            // pre -> n1 -> n2 -> temp...
            // pre -> n2 -> n1 -> temp...
            temp = n2.next;
            pre.next = n2;
            n2.next = n1;
            n1.next = temp;
            //                          n2 -> pre-> head
            // move to next pair, ...-> n2 -> n1 -> temp ...
            pre = pre.next.next;
            head = temp;
        }
        return dummy.next;
    }
}

// recursion
public class Solution2 {
    public ListNode SwapPairs(ListNode head) {
        if (head == null || head.next == null) return head;
        ListNode n = head.next;
        head.next = SwapPairs(n.next);
        n.next = head;
        return n;
    }
}