from typing import List


class Solution:
    # adapt where it doesn't contain duplicate triplets lists
    def threeSum(self, nums: List[int]) -> List[List[int]]:
        triplet_list = []
        nums.sort()

        for i, a in enumerate(nums):
            if a > 0:
                break
            if i > 0 and a == nums[i-1]: # checks if value at index is same as past index value
                continue

            p1 = i + 1
            p2 = len(nums) - 1

            while p1 < p2:
                threeSum = nums[i] + nums[p1] + nums[p2]

                if threeSum > 0:
                    p2 -= 1
                elif threeSum < 0:
                    p1 += 1
                else:
                    triplet_list.append([a, nums[p1], nums[p2]])
                    p1 += 1
                    p2 -= 1
                    while nums[p1] == nums[p1-1] and p1 < p2:
                        p1 += 1

        return triplet_list



# nums = [-1,0,1,2,-1,-4]
nums = [0,0,0]
solution = Solution()
print(solution.threeSum(nums))


