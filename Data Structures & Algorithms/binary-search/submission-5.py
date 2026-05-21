class Solution:
    def search(self, nums: List[int], target: int) -> int:
        l = 0
        r = len(nums) - 1

        while l <= r:
            mid_point = (l + r) // 2

            if target < nums[mid_point]:
                r = mid_point - 1
            elif target > nums[mid_point]:
                l = mid_point + 1
            else:
                return mid_point

        return -1

nums=[8]
solution = Solution()
print(solution.search(nums, 8))