using System;

namespace LeetcodeCShaprDotNetCore {
    class Program {
        static void Main(string[] args) {
            var list = new ListNode(1) {
                next = new ListNode(2) {
                    next = new ListNode(6) {
                        next = new ListNode(3) {
                            next = new ListNode(4) {
                                next = new ListNode(5) {
                                    next = new ListNode(6)
                                }
                            }
                        }
                    }
                }
            };
            var s = new Solution();
            var nlist = s.RemoveElements(list, 6);
            while (nlist != null) {
                Console.Write(nlist.val + "->");
                nlist = nlist.next;
            }
        }
    }
}

/*
Example
Given: 1 --> 2 --> 6 --> 3 --> 4 --> 5 --> 6, val = 6
Return: 1 --> 2 --> 3 --> 4 --> 5
*/