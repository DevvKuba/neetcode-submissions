from typing import List


class Solution:
    def isValidSudoku(self, board: List[List[str]]) -> bool:

        def is_unique(lst):
            nums = [x for x in lst if x != "."]  # Ignore "."
            
            return len(nums) == len(set(nums))  # Ensure only digits are unique

        # check all rows
        for row in board:
            if not is_unique(row):
                return False

        # check all columns
        for col in range(9):
            if not is_unique([board[row][col] for row in range(9)]):
                return False

        # check all 3x3 boxes

                            #range(start,stop,step)
        for box_rows in range(0,9,3): # row at index 0, 3, 6
            for box_cols in range(0,9,3): # row at index 0 ,3, 6
                box = [
                    board[r][c]
                    for r in range(box_rows, box_rows + 3)
                    for c in range(box_cols, box_cols + 3)
                ]
                if not is_unique(box):
                    return False

        return True




