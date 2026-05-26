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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {

        ListNode curr1 = list1;
        ListNode curr2 = list2;

        ListNode dummy = new ListNode(0);

        ListNode newListHead = dummy;

        while(curr1 != null && curr2 != null){
            if(curr1.val > curr2.val)
            {
                newListHead.next = curr2;
                newListHead = curr2;
                curr2 = curr2.next;
            }
            else if(curr1.val < curr2.val )
            {
                newListHead.next = curr1;
                newListHead = curr1;
                curr1 = curr1.next;
            }
            // they are the same so just choose one case
            else 
            {
                newListHead.next = curr1;
                newListHead = curr1;
                curr1 = curr1.next;
            }
        }

        // final step around merging remaining list

        if(curr1 != null)
        {
            newListHead.next = curr1;
        }
        else if(curr2 != null)
        {
            newListHead.next = curr2;
        }

        return dummy.next;
    }
}