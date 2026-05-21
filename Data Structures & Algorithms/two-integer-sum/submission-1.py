class Solution:
    def twoSum(self, nums: list[int], target: int) -> list[int]:
        dict_ = {}
        indexes = []

        for index, num in enumerate(nums):
            target_num = target - num
            if target_num in dict_:
                indexes.append(dict_.get(target_num))
                indexes.append(index)
                return indexes
            dict_[num] = index


solution = Solution()
print(solution.twoSum([4,5,6], 10))
print(solution.twoSum([5,5], 10))