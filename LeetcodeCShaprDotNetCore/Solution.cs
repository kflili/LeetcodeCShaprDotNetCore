using System;
using System.Collections.Generic;
using System.Text;

namespace LeetcodeCShaprDotNetCore {
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
}

/*
Example
Given: 1 --> 2 --> 6 --> 3 --> 4 --> 5 --> 6, val = 6
Return: 1 --> 2 --> 3 --> 4 --> 5
*/
