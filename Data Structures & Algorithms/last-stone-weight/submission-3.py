class Solution:
    def lastStoneWeight(self, stones: List[int]) -> int:
        # [6 ,5, 2, 3]
        maxS = max(stones) # 6
        bucket = [0] * (maxS + 1) # [0, 0, 0, 0, 0, 0, 0]
        for stone in stones:
            bucket[stone] += 1 # [0, 0, 1, 1, 0, 1, 1]
        
        first = second = maxS # 6 
        while first > 0:
            if bucket[first] % 2 == 0:
                first -= 1 # 4
                continue
            j = min(first - 1, second) # 5 # 3
            while j > 0 and bucket[j] == 0: 
                j -= 1
            
            if j == 0:
                return first
            
            second = j # 5 # 3
            bucket[first] -= 1 # [0, 0, 1, 1, 0, 1, 0] 
            bucket[second] -= 1 # [0, 0, 1, 1, 0, 0, 0] 
            bucket[first - second] += 1 # [0, 1, 1, 1, 0, 0, 0] 
            first = max(first - second, second) # first = 5
        return first