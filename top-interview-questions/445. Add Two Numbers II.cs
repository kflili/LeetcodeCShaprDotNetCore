// reverse list, add, and then reverse back
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        l1 = Reverse(l1);
        l2 = Reverse(l2);
        return Reverse(AddList(l1, l2));
    }
    private ListNode AddList(ListNode l1, ListNode l2) {
        ListNode dummy = new ListNode(0);
        ListNode tail = dummy;
        int carry = 0;
        int sum = 0;
        while (l1 != null || l2 != null) {
            int x = (l1 != null) ? l1.val : 0;
            int y = (l2 != null) ? l2.val : 0;
            sum = x + y + carry;
            tail.next = new ListNode(sum % 10);
            tail = tail.next;
            carry = (sum) / 10;
            l1 = (l1 != null)?l1.next : null;
            l2 = (l2 != null)?l2.next : null;
        }
        while (carry != 0) {
            tail.next = new ListNode(carry % 10);
            tail = tail.next;
            carry /= 10;
        }
        return dummy.next;
    }
    private ListNode Reverse(ListNode head) {
        ListNode pre = null;
        while (head != null) {
            ListNode temp = head.next;
            head.next = pre;
            pre = head;
            head = temp;
        }
        return pre;
    }
}

// follow up: don't modifie input list, In other words, reversing the lists is not allowed.
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        var s1 = new Stack<ListNode>();
        var s2 = new Stack<ListNode>();
        while (l1 != null) {
            s1.Push(l1);
            l1 = l1.next;
        }
        while (l2 != null) {
            s2.Push(l2);
            l2 = l2.next;
        }
        int sum = 0;
        ListNode head = new ListNode(0);
        while (s1.Count > 0 || s2.Count > 0) {
            if (s1.Count > 0) sum += s1.Pop().val;
            if (s2.Count > 0) sum += s2.Pop().val;
            head.val = sum % 10;
            ListNode pre = new ListNode(sum / 10);
            sum /= 10;
            pre.next = head;
            head = pre;
        }
        return head.val == 0 ? head.next : head;
    }
}