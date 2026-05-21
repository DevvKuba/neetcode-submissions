/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        if(head.next == null) return null;
        ListNode dummy = new ListNode();
        dummy.next = head;
        var first = head;
        var second = dummy;

        while(n > 0){
            first = first.next;
            n--;
        }

        while(first != null){
            first = first.next;
            second = second.next;
        }
        second.next = second.next.next;

        return dummy.next;




    }
}
