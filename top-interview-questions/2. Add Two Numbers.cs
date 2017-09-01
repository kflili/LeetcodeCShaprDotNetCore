// O(1) space
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        if (l1 == null) return l2;
        if (l2 == null) return l1;
        ListNode dummy = new ListNode(0);
        ListNode head = dummy;
        int carry = 0;
        int sum = 0;
        while (l1 != null && l2 != null) {
            head.next = l1;
            head = head.next;
            sum = l1.val + l2.val + carry;
            head.val = sum % 10;
            carry = sum / 10;
            l1 = l1.next;
            l2 = l2.next;
        }
        if (l1 != null) {
            head.next = l1;
        } 
        if (l2 != null) {
            head.next = l2;
        }
        
        while (head.next != null) {
            head = head.next;
            sum = head.val + carry;
            head.val = sum % 10;
            carry = sum / 10;
            if (carry == 0) break;
        }
        if (carry != 0) {
            head.next = new ListNode(carry);
        }
        return dummy.next;
    }
}

// O(m+n) space
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        if (l1 == null) return l2;
        if (l2 == null) return l1;
        ListNode dummy = new ListNode(0) { next = l1 };
        ListNode cur = dummy;
        int carry = 0;
        int sum = 0;
        while (l1 != null || l2 != null) {
            int x = (l1 != null) ? l1.val : 0;
            int y = (l2 != null) ? l2.val : 0;
            sum = x + y + carry;
            cur.next = new ListNode(sum % 10);
            carry = sum / 10;
            if (l1 != null) l1 = l1.next;
            if (l2 != null) l2 = l2.next;
            cur = cur.next;
        }
        if (carry != 0) {
            cur.next = new ListNode(carry);
        }
        return dummy.next;
    }
}