class Solution:

    def isAnagram(self, s: str, t: str) -> bool:
        map_1 = {}
        map_2 = {}
        for letter in s:
            if letter in map_1:
                current_value = map_1.get(letter)
                map_1[letter] = current_value + 1
            else:
                map_1[letter] = 1

        for letter in t:
            if letter in map_2:
                current_value = map_2.get(letter)
                map_2[letter] = current_value + 1
            else:
                map_2[letter] = 1

        if map_1 == map_2:
            return True
        else:
            return False



solution = Solution()
print(solution.isAnagram(s="racecar", t="carrace"))
print(solution.isAnagram(s="jar", t="jam"))
print(solution.isAnagram(s="xx", t="x"))