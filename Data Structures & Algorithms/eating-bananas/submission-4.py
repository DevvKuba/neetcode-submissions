import math
from typing import List

class Solution:
    def minEatingSpeed(self, piles: List[int], h: int) -> int:
       
        l = 1
        r = max(piles)

        res = r
        hours_taken = 0
        while l <= r: # <= to check in case both l & r are the same

            k = (l + r)//2 #mid_point
            for num in piles:
                hours_taken += math.ceil(float(num) / k)
                # while num > 0:
                #         num -= k
                #         hours_taken += 1

            if hours_taken > h:
                l = k + 1
            elif hours_taken <= h:
                r = k -1 # right traverses to lower number hence.. it
                res = k # ensures res holds smallest k value
            hours_taken = 0

        return res

