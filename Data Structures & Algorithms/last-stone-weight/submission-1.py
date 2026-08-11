class Solution:
    def lastStoneWeight(self, stones: List[int]) -> int:
        i = 0
        while len(stones) > 1:
            stones.sort(reverse=True)
            first = stones.pop(0)
            second = stones.pop(0)
            if first != second:
                stones.append(first - second)
        return stones[0] if stones else 0

            