/*
traverse right and increment rowBegin, then traverse down and decrement colEnd, 
traverse left and decrement rowEnd, and finally I traverse up and increment colBegin.

The only tricky part is that when traverse left or up, we have to check whether the 
row or col still exists to prevent duplicates. 
 */
public class Solution {
    public IList<int> SpiralOrder(int[,] matrix) {
        List<int> res = new List<int>();
        if (matrix.GetLength(0) == 0) {
            return res;
        }
        int rowBegin = 0;
        int rowEnd = matrix.GetLength(0) - 1;
        int colBegin = 0;
        int colEnd = matrix.GetLength(1) - 1;
        while (rowBegin <= rowEnd && colBegin <= colEnd) {
            // traverse right
            for (int i = colBegin; i <= colEnd; i++) {
                res.Add(matrix[rowBegin, i]);
            }
            rowBegin++;
            // traverse down
            for (int i = rowBegin; i <= rowEnd; i++) {
                res.Add(matrix[i, colEnd]);
            }
            colEnd--;
            if (rowBegin <= rowEnd) {
                // traverse left
                for (int i = colEnd; i >= colBegin; i--) {
                    res.Add(matrix[rowEnd, i]);
                }
            }
            rowEnd--;
            if (colBegin <= colEnd) {
                // traverse up
                for (int i = rowEnd; i >= rowBegin; i--) {
                    res.Add(matrix[i, colBegin]);
                }
            }
            colBegin++;
        }
        return res;
    }
}