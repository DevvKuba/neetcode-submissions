class Solution:
    
    def isValidSudoku(self, board: List[List[str]]) -> bool:

        def is_unique(lst):
            elements = [num for num in lst if num != "."]
            return len(elements) == len(set(elements))

        for row in board:
            if not is_unique(row):
                return False
        for col in range(9):
            if not is_unique([board[row][col] for row in range(9)]):
                return False

        for box_row in range(0,9,3):
            for box_col in range(0,9,3):
                box = [
                    board[r][c]
                    for r in range(box_row,box_row+3)
                    for c in range(box_col, box_col+3)
                ]
                if not is_unique(box):
                    return False
        return True

            