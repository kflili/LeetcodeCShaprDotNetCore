/*
store states of each row in the first martix[i, 0], and store states 
of each column in the first matrix[0,j]. Because the state of row0 and 
the state of column0 would occupy the same cell, use bool col0Zero for col0.
In first traverse, set states martix[i, 0], matrix[0,j] by looping 
in a top-down way. 
In the second phase, use states to set matrix elements in a bottom-up way.
 */
public class Solution {
    public void SetZeroes(int[,] matrix) {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        bool col0Zero = false;
        for (int i = 0; i < rows; i++) {
            if (matrix[i,0] == 0) col0Zero = true;
            for (int j = 1; j < cols; j++) {
                if (matrix[i, j] == 0) {
                    matrix[i, 0] = 0;
                    matrix[0, j] = 0;
                }
            }
        }
        for (int i = rows - 1; i >= 0; i--) {
            for (int j = cols - 1; j >= 1; j--) {
                if (matrix[i, 0] == 0 || matrix[0, j] == 0)
                    matrix[i, j] = 0;
            }
            if (col0Zero) matrix[i, 0] = 0;
        }
    }
}