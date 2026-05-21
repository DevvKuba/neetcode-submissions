from typing import List


class Solution:
     def findMin(self, nums: List[int]) -> int:
        res = nums[0]
        l = 0
        r = len(nums) - 1

        while l <= r:
            if nums[l] < nums[r]:
                res = min(res, nums[l]) # smallest res between current and l value
                break # returns res

            m = (l + r) //2
            res = min(res, nums[m]) # tracks min value we have stored
            if nums[m] >= nums[l]:
                l = m + 1
            else:
                r = m - 1

        return res



