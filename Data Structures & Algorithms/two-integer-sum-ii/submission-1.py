from typing import List


class Solution:
    def twoSum(self, numbers: List[int], target: int) -> List[int]:
        sums_index_list = []
        sums_dict = {}
        for i,n in enumerate(numbers, 1):
            sums_dict[n] = i
        for n in numbers:
            sums_index_list.append(sums_dict.get(n)) # append index at n
            target_num = target - n
            if target_num in sums_dict:
                target_num_index = sums_dict.get(target_num)
                sums_index_list.append(target_num_index)
                return sums_index_list
            else:
                sums_index_list.pop()



