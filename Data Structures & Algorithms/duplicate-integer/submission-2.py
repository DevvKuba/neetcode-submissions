class Solution:
    @staticmethod
    def hasDuplicate(list_):
        dict_ = {}
        for i in list_:
            if dict_.get(i) is not None and i in dict_:
                new_value = dict_.get(i) + 1
                dict_[i] = new_value
                return True
            else:
                dict_[i] = 1
        return False


 


solution = Solution()
print(solution.hasDuplicate([1, 2, 3, 3, 3, 3]))
print(solution.hasDuplicate([1, 2, 3, 4]))