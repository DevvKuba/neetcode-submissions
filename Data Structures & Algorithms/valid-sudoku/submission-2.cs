public class Solution {
    public bool IsValidSudoku(char[][] board) {
        HashSet<char> set = new  HashSet<char>();

        for (int i = 0; i < board.Length; i++) {
            for (int j = 0; j < board.Length; j++) {
                var row = board[i][j];

                if(row == '.') continue;

                if(set.Contains(row)){
                    return false;
                }
                else {
                    set.Add(row);
                }
            }
            set.Clear();
        }

        for (int i = 0; i < board.Length; i++) {
            for (int j = 0; j < board.Length; j++) {
                var col = board[j][i];

                if(col == '.') continue;

                if(set.Contains(col)){
                    return false;
                }
                else {
                    set.Add(col);
                }
            }
            set.Clear();
        }

        Dictionary<(int,int), HashSet<char>> dict = new Dictionary<(int,int), HashSet<char>>();

        for (int i = 0; i < board.Length; i++) {
            for (int j = 0; j < board.Length; j++) {
                var value = board[i][j];
                
                (int,int) sector = (i / 3, j / 3);

                if(dict.ContainsKey(sector)){

                    if(value == '.') continue;

                    if(dict[sector].Contains(value)){
                        return false;
                    }
                    else {
                        dict[sector].Add(value);
                    }
                }
                else {
                    dict[sector] = new HashSet<char>{value};
                }
            }
        }

        // end 
        return true;
    }
}
