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
                if st and st[-1] == match[c]:
                    st.pop()
                else:
                    return False
            else:
                st.append(c)
        return not st
        