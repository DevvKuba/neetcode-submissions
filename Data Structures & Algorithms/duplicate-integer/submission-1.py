class Solution:
    def hasDuplicate(self, nums: list[int]) -> bool:
        seen = set()
        for num in nums:
            if num in seen:
                return True
            seen.add(num)
        return False


solution = Solution()
print(solution.hasDuplicate([1, 2, 3, 3]))
print(solution.hasDuplicate([1, 2, 3, 4]))