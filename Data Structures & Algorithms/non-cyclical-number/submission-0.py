class Solution:
    def isHappy(self, n: int) -> bool:
        slow, fast = n, self.sumOfSq(n)

        while slow != fast:
            fast = self.sumOfSq(fast)
            fast = self.sumOfSq(fast)
            slow = self.sumOfSq(slow)
        return True if fast == 1 else False

    def sumOfSq(self, n: int) -> int:
        output = 0

        while n:
            digit = n % 10
            digit = digit ** 2
            output += digit
            n = n // 10
        return output