from typing import List


class Solution:
    def evalRPN(self, tokens: List[str]) -> int:
        operators = {"+": "+", "*" : "*", "-" : "-", "/" : "/" }
        stack = []
        for t in tokens:
            if t in operators:
                if t == operators.get("+"):
                    last_num = int(stack.pop())
                    top_num = int(stack.pop())
                    stack.append(top_num +last_num)

                if t == operators.get("-"):
                    last_num = int(stack.pop())
                    top_num = int(stack.pop())
                    stack.append(top_num - last_num)

                if t == operators.get("*"):
                    last_num = int(stack.pop())
                    top_num = int(stack.pop())
                    stack.append(top_num * last_num)

                if t == operators.get("/"):
                    last_num = int(stack.pop())
                    top_num = int(stack.pop())
                    stack.append(int(top_num / last_num))

            else:
                stack.append(int(t))

        return stack[0]

