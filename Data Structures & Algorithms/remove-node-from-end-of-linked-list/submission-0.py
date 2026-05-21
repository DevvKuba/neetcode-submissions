# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next

class Solution:
    def removeNthFromEnd(self, head: Optional[ListNode], n: int) -> Optional[ListNode]:

        nodes = []
        temp = head
        dummy = ListNode(0)

        while temp:
            nodes.append(temp.val) # adding nodes
            temp = temp.next
        
        target_node = n * -1
        nodes.pop(target_node)
        
        current = dummy
        for value in nodes:
            current.next = ListNode(value)
            current = current.next
        return dummy.next



        