/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */

// recursion
public class Solution {
    public ListNode SwapPairs(ListNode head) {
        if (head == null || head.next == null) return head;
        ListNode n2 = head.next;
        // swap tail part
        ListNode swapedTail = SwapPairs(n2.next);
        // swap head and n2
        n2.next = head;
        head.next = swapedTail;
        return n2;
    }
}

// iteration
public class Solution {
    public ListNode SwapPairs(ListNode head) {
        if (head == null || head.next == null) return head;
        ListNode dummy = new ListNode(0);
        dummy.next = head;
        ListNode pre = dummy;
        while (pre.next != null && pre.next.next != null) {
            // initialize state before swap : pre -> n1 -> n2 -> tail
            var n1 = pre.next;
            var n2 = n1.next;
            var tail = n2.next;
            // do the swap and record the state: pre->n2->n1->tail
            pre.next = n2;
            n2.next = n1;
            n1.next = tail;
            // prepare for next loop, shift pre in 2 steps
            pre = n1;
        }
        return dummy.next;
    }
}

/*
Next challenges: 
Reverse Nodes in k-Group
 */