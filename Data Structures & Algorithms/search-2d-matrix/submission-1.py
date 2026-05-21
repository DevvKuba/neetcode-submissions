class Solution:
    def searchMatrix(self, matrix: List[List[int]], target: int) -> bool:
        for list_ in matrix:
            if target in list_:
                l = 0
                r = len(list_)- 1

                while l <= r:
                    mid_point = (l + r) // 2

                    if target > list_[mid_point]:
                        l = mid_point + 1
                    elif target < list_[mid_point]:
                        r = mid_point - 1
                    else:
                        return True

        return False


        