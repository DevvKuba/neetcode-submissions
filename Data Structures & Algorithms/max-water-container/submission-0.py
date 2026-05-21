from random import randint
from typing import List



class Solution:
    def maxArea(self, heights: List[int]) -> int:
        area = 0
        l = 0
        r = len(heights) - 1
        while l < r:
            new_area = ((max(l, r) - min(l ,r)) * (min(heights[l], heights[r])))
            if new_area > area:
                area = new_area

            if heights[l] < heights[r]:
                l += 1
            elif heights[r] < heights[l]:
                r -= 1
            else:
                l += 1
        return area


