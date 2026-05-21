class Solution:
    def twoSum(self, nums, target):
        _dict = {}
        indexes = []

        for i,n in enumerate(nums):
            target_num = target - n
            if target_num in _dict:
                indexes.append(_dict.get(target_num))
                indexes.append(i)
            else:
                _dict[n] = i
        return indexes

