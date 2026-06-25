class Solution:
    def isValid(self, s: str) -> bool:
        if len(s) % 2:
            return False
        match = {
            ")": "(", 
            "}": "{", 
            "]": "["
        }
        st = []
        for c in s:
            if c in match:
                if not st or st[-1] != match[c]:
                    return False
                st.pop()
            else:
                st.append(c)
        return not st