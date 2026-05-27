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
    public bool HasCycle(ListNode head) {
        ListNode fast = head;
        ListNode slow = head;

        if(head == null || head.next == null) return false;

        while(fast != null && slow != null)
        {
            if(fast.next == null) 
            {
                fast = fast.next;
            }
            else 
            {
                 fast = fast.next.next;
            }

            slow = slow.next;

            if(fast == slow) return true;
        }
        return false;
    }
}
