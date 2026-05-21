from typing import List


class Solution:
    def topKFrequent(self, nums: List[int], k: int) -> List[int]:
        num_dict = {}
        k_elements = []
        for n in nums:
            if n in num_dict:
                new_value = num_dict.get(n) + 1
                num_dict[n] = new_value
            else:
                num_dict[n] = 1

        while k > 0:
            largest_value = max(num_dict, key=num_dict.get) # most frequent key
            k_elements.append(largest_value)
            num_dict.pop(largest_value)
            k -= 1
        return k_elements


nums = [1,2,2,2,2,3,3,3]
nums_2 = [7,7]
k =2
k_2 = 1

solution = Solution()
print(solution.topKFrequent(nums, k))
print(solution.topKFrequent(nums_2, k_2))