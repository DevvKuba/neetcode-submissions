# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right

class Solution:
    def maxDepth(self, root: Optional[TreeNode]) -> int:
        
        if root is None:
            return 0

        levels = 0
        queue = []
        queue.append(root)

        while len(queue) > 0:

            for _ in range(len(queue)):
                root = queue.pop(0)
                if root.left is not None:
                    queue.append(root.left)
                if root.right is not None:
                    queue.append(root.right)
            levels += 1 # at the end of the for loop when a level is traversed
        return levels

        
        
        