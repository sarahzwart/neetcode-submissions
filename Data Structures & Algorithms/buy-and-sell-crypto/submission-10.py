class Solution:
    def maxProfit(self, prices: List[int]) -> int:
        minV = prices[0]
        maxP = 0
        for p in prices:
            maxP = max(maxP, p - minV)
            minV = min(minV, p)
        return maxP
