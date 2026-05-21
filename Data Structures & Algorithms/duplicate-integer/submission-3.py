from typing import List


class Solution:
    def hasDuplicate(self, nums: List[int]) -> bool:

        my_dict = {}

        for num in nums:
            if num not in my_dict:
                my_dict[num] = 1;
            else:
                current_count = my_dict.get(num)
                my_dict[num] = current_count + 1
        for num in my_dict:
            if my_dict[num] > 1:
                return True
        return False


solution = Solution()
print(solution.hasDuplicate([1,2,3,3]))
