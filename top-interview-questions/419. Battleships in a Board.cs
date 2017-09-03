/*
count only the "first" cell of the battleship. 
First cell will be defined as the most top-left cell. 
We can check for first cells by only counting cells that 
do not have an 'X' to the left and do not have an 'X' above them.
 */
public class Solution {
    public int CountBattleships(char[,] board) {
        int m = board.GetLength(0);
        int n = board.GetLength(1);
        int count = 0;
        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                if (board[i,j] == 'X' 
                    && (i == 0 || board[i - 1,j] == '.')
                    && (j == 0 || board[i, j - 1] == '.')) {
                    count++;
                }
            }
        }
        return count;
    }
}