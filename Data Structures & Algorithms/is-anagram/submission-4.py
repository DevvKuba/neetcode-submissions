class Solution:

    def isAnagram(self, s: str, t: str) -> bool:

        dict_1 = {}
        dict_2 = {}

        for _str in s:
             if _str not in dict_1:
                 dict_1[_str] = 1
             else:
                 current_val = dict_1.get(_str)
                 dict_1[_str] = current_val + 1

        for _str in t:
            if _str not in dict_2:
                dict_2[_str] = 1
            else:
                current_val = dict_2.get(_str)
                dict_2[_str] = current_val + 1

        if dict_1 == dict_2:
            return True
        else:
            return False




solution = Solution()
print(solution.isAnagram(s="racecar", t="carrace"))
print(solution.isAnagram(s="jar", t="jam"))
print(solution.isAnagram(s="xx", t="x"))