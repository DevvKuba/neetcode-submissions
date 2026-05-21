class Solution:
    def twoSum(self, nums, target):
        nums_dict = {}
        indexes = []
        for i,n in enumerate(nums):
            nums_dict[n] = i

        for j in range(len(nums)):
            target_num = target - nums[j]
            if target_num in nums_dict and nums_dict[target_num] != j:
                indexes.append(j)
                indexes.append(nums_dict[target_num])
                return indexes
        return None


solution = Solution()
print(solution.twoSum([5, 5], 10))
print(solution.twoSum(nums=[1,3,4,2], target=6))

