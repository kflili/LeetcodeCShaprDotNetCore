using System;
using System.Collections.Generic;
using System.Text;

namespace LeetcodeCShaprDotNetCore
{
    public class Solution
    {
        public ListNode RotateRight(ListNode head, int k)
        {
            if (head == null || head.next == null) return head;
            // get length
            int len = 1;
            ListNode tail = head;
            while (tail.next != null)
            {
                tail = tail.next;
                len++;
            }
            // connect circle
            tail.next = head;
            // find new head;
            var n = len - k % len;
            while (n > 0)
            {
                tail = head;
                head = head.next;
                n--;
            }
            // cut before the new head
            tail.next = null;
            return head;
        }
    }
}