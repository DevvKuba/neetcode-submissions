from typing import List


class Solution:
    def twoSum(self, numbers: List[int], target: int) -> List[int]:
        # sums_index_list = []
        pointer_1 = 0
        pointer_2 = len(numbers)-1

        while numbers[pointer_1] < numbers[pointer_2]:
            sum = numbers[pointer_1] + numbers[pointer_2]

            if sum < target:
                pointer_1 += 1
            elif sum > target:
                pointer_2 -= 1
            elif sum == target:
                return [pointer_1+1, pointer_2+1]
        return -1



