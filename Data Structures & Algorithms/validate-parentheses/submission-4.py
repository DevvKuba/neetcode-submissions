class Solution:
    def isValid(self, s: str) -> bool:
        stack = []
        closedToOpen = { ")": "(", "]": "[", "}": "{"}

        for c in s:
            if c in closedToOpen: # if closed parenthesis
                if len(stack) != 0 and stack[-1] == closedToOpen.get(c):
                    stack.pop()
                else:
                    return False
            else:
                stack.append(c)
        return True if not stack else False # stacks need to be empty
        # otherwise it shows it's not valid