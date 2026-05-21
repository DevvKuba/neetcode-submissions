class Solution:
    def twoSum(self, nums: list[int], target: int) -> list[int]:
        num_dict = {}
        i_list = []
        for i,n in enumerate(nums):
            lf_num = target - n
            if lf_num in num_dict:
                i_list.append(num_dict.get(lf_num))
                i_list.append(i)
            num_dict[n] = i


        return i_list

solution = Solution()
print(solution.twoSum([4, 5, 6], 10))
print(solution.twoSum([5, 5], 10))