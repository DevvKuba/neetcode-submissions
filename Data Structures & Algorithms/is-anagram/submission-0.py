class Solution:

    def isAnagram(self, s: str, t: str) -> bool:
        check_list_s = []
        check_list_t = []
        for letter in s:
            check_list_s.append(letter)
        check_list_s.sort()
        for letter in t:
            check_list_t.append(letter)
        check_list_t.sort()

        if check_list_s == check_list_t:
            return True
        else:
            return False


solution = Solution()
print(solution.isAnagram(s="racecar", t="carrace"))
print(solution.isAnagram(s="jar", t="jam"))


