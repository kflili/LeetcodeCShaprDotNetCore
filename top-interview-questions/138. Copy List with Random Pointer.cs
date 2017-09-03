/*
1. generate new nodes and make the maping old -> new
2. loop the old, use map to get all random and next.
 */
public class Solution {
    public RandomListNode CopyRandomList(RandomListNode head) {
        if (head == null) return null;
        Dictionary<RandomListNode, RandomListNode> dict = new Dictionary<RandomListNode,RandomListNode>();
        GenerateAllNodesAndMapping(head, dict);
        CopyList(head, dict);
        return dict[head];
    }
    private void GenerateAllNodesAndMapping(RandomListNode head, Dictionary<RandomListNode, RandomListNode> dict) {
        while (head != null) {
            RandomListNode node = new RandomListNode(head.label);
            dict.Add(head, node);
            head = head.next;
        }
    }
    private void CopyList(RandomListNode head, Dictionary<RandomListNode, RandomListNode> dict) {
        while (head != null) {
            RandomListNode temp = dict[head];
            if (head.next != null) {
                temp.next = dict[head.next];
            } 
            if (head.random != null) {
                temp.random = dict[head.random];
            }
            head = head.next;
        }
    }
    
}
/**
 * Definition for singly-linked list with a random pointer.
 * public class RandomListNode {
 *     public int label;
 *     public RandomListNode next, random;
 *     public RandomListNode(int x) { this.label = x; }
 * };
 */