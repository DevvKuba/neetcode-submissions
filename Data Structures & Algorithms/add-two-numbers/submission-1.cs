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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode dummy = new ListNode();
        ListNode temp = dummy;

        int remainder = 0;
        while(l1 != null || l2 != null || remainder != 0){
            int v1 = l1 != null ? l1.val : 0;
            int v2 = l2 != null ? l2.val : 0;

            // new digit
            int val = v1 + v2 + remainder;
            remainder = val / 10;
            val = val % 10;
            temp.next = new ListNode(val);

            // update pointers
            temp = temp.next;
            l1 = l1 != null ? l1.next : null;
            l2 = l2 != null ? l2.next : null;
        }

        return dummy.next;
    }

}
