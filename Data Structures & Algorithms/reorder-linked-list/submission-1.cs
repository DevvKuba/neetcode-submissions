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
    public void ReorderList(ListNode head) {
        // use s & f pointers to seperate the list in 2
        var slow = head;
        var fast = head.next;

        while(fast != null && fast.next != null){
            slow = slow.next;
            fast = fast.next.next;
        }

        //slit into two lists
        var second = slow.next;
        slow.next = null;
        ListNode prev = null;

        // reverse 2nd potion of the list
        while(second != null){
            var temp = second.next;
            second.next = prev;
            prev = second;
            second = temp;
        }

        // merge two halves
        
        // heads for both of the lists
        var first = head;
        second = prev;
        while(second != null){
            var temp1 = first.next;
            var temp2 = second.next;

            first.next = second;
            second.next = temp1;
            first = temp1;
            second = temp2;
        }
    }
}
