class Solution:
    def isValid(self, s: str) -> bool:
        stack = []
        p_dict = {"}": "{", ")": "(", "]": "["}

        for p in s:
            if p in p_dict:
                try:
                    if p_dict.get(p) != stack.pop():
                        return False
                except:
                    return False
            else:
                stack.append(p)

        if len(stack) == 0:
            return True
        else:
            return False