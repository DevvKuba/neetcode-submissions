class Solution:
    def findMin(self, nums: List[int]) -> int:
        min_index = 0
        for i in range(len(nums)-1):
            if nums[i+1] < nums[i]:
                min_index = i + 1
        return nums[min_index]

