from typing import List


class Solution:
    # adapt where it doesn't contain duplicate triplets lists
    def threeSum(self, nums: List[int]) -> List[List[int]]:
        triplet_list = []
        for i in range(len(nums)):
            for j in range(i+1, len(nums)):
                for z in range(j+1, len(nums)):
                    sum = nums[i] + nums[j] + nums[z]
                    if sum == 0:
                        nums_list = sorted([nums[i], nums[j], nums[z]])
                        if nums_list not in triplet_list:
                            triplet_list.append(nums_list)

        return triplet_list

