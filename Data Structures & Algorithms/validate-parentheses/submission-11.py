class Solution:
    def isValid(self, s: str) -> bool:
        parens = {
            ')':'(',
            ']':'[',
            '}':'{'
        }
        stack = []
        # ({})
        for p in s:
            if p in parens:
                if stack and stack[-1] == parens[p]:
                    stack.pop()
                else:   
                    return False
            else:
                stack.append(p)

        return len(stack) == 0
