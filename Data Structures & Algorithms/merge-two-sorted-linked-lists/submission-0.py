# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next

class Solution:
    def mergeTwoLists(self, list1: Optional[ListNode], list2: Optional[ListNode]) -> Optional[ListNode]:
        dummy = temp = ListNode()
            # temp is a pointe to dummy_node
            # temp will be our tail after all iterations

        while list1 and list2:
            if list1.val < list2.val:
                temp.next = list1
                list1 = list1.next
            else:
                temp.next = list2
                list2 = list2.next
            temp = temp.next

        while list1:
            temp.next = list1
            temp = list1
            list1 = list1.next

        while list2:
            temp.next = list2
            temp = list2
            list2 = list2.next

        return dummy.next
