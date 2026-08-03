class Solution:
    def isPalindrome(self, s: str) -> bool:
        l,r = 0, len(s) - 1
        while (l < r):
            while not self.isAlphaNum(s[r]) and r > l:
                r = r - 1
            while not self.isAlphaNum(s[l]) and l < r :
                l = l + 1
            if  l < r and s[l].lower() != s[r].lower():
                return False
            l = l + 1
            r = r - 1
        return True
    def isAlphaNum (self, c: chr):
        return (c >= 'a' and c <= 'z') or (c >= 'A' and c <= 'Z') or (c >= '0'and c <= '9')

