/*
 1. fast begins at head.next is a good way to find middle point.
 2. for this problem, draw a pic is a good for solving problem
 Let the distance from the first node to the the node where cycle
  begins be A, and let say the slow pointer travels travels A+B. 
  The fast pointer must travel 2A+2B to catch up. The cycle size is N. 
  Full cycle is also how much more fast pointer has traveled than 
  slow pointer at meeting point.
    A + B + N = 2A + 2B + 1 (because fast starts at 1 not 0)
    N = A + B + 1.
    So the slow need move N - B to reach the cycly start point. i.e. A + 1
    Therefore slow2 move A, and slow move A, then slow.next == slow is pointing
    to the cysly starting point.
 */
public class Solution {
    public ListNode DetectCycle(ListNode head) {
        if (head == null || head.next == null) {
            return null;
        }
        ListNode slow = head, fast = head.next;
        while (fast != slow) {
            if (fast == null || fast.next == null) {
                return null;
            }
            slow = slow.next;
            fast = fast.next.next;
        }
        ListNode slow2 = head;
        while (slow2 != slow.next) {
            slow = slow.next;
            slow2 = slow2.next;
        }
        return slow2;
    }
}