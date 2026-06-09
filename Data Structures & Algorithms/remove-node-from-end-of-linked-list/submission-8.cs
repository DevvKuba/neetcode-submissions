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
        if(head.next == null && n == 1){
            return head.next; // returing null
        }

        ListNode prev = null;
        ListNode curr = head;

        while(curr != null){
            ListNode tmp1 = curr.next;
            curr.next = prev;
            prev = curr;
            curr = tmp1;
        }

        ListNode newHead = prev;
        // prev at current head at the end of reversal
        ListNode start = prev;
        ListNode tmp2 = null;
        int counter = 1;

        while(start != null){
            // start case
            if(counter == n && tmp2 == null) { 
                newHead = start.next;
                start.next = null;
                break;
            }
            // middle / end case IS the same
            else if(counter == n){
                tmp2.next = start.next;
                start.next = null;
                break;
            }
            counter++;
            tmp2 = start;
            start = start.next;
        }

        // reverse again ?
        prev = null;
        curr = newHead;

        while(curr != null){
            ListNode tmp1 = curr.next;
            curr.next = prev;
            prev = curr;
            curr = tmp1;
        }
        return prev;

       
    }
}
