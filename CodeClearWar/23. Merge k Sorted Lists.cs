/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
/*
O(nk log k) runtime, O(1) space – Divide and conquer using two way merge:
 */
public class Solution {
    public ListNode MergeKLists(ListNode[] lists) {
        return MergeKLists(lists, 0, lists.Length - 1);
    }
    
    private ListNode MergeKLists(ListNode[] lists, int left, int right) {
        if (left > right) return null;
        if (left == right) return lists[left];
        int mid = left + (right - left) / 2;
        ListNode leftNode = MergeKLists(lists, left, mid);
        ListNode rightNode = MergeKLists(lists, mid + 1, right);
        return MergeTwoLists(leftNode, rightNode);
    }
    
    private ListNode MergeTwoLists(ListNode l1, ListNode l2) {
        ListNode dummy = new ListNode(0);
        var tail = dummy;
        while (l1 != null && l2 != null) {
            if (l1.val < l2.val) {
                tail.next = l1;
                l1 = l1.next;
            } else {
                tail.next = l2;
                l2 = l2.next;
            }
            tail = tail.next;
        }
        if (l1 != null) tail.next = l1;
        if (l2 != null) tail.next = l2;
        return dummy.next;
    }
}