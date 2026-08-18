class Solution:
    def missingNumber(self, nums: List[int]) -> int:
        res = len(nums) # 2 [1, 0]
        for i in range(len(nums)): 
            res += i - nums[i]
        return res