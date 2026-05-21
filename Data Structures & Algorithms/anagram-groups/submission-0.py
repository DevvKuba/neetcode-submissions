from collections import defaultdict
from typing import List


class Solution:
    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:

        a = defaultdict(list) # dictionary where values initialised as lists
        for word in strs:
            s = "".join(sorted(word))
            a[s].append(word)

        res = list(a.values()) # returns all values in list
        return res



strs = ["act","pots","tops","cat","stop","hat"]
solution = Solution()
print(solution.groupAnagrams(strs))

