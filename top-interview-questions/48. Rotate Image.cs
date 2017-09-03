// clock-wise rotate,先对角对折, 再横向对折
// anti-clockwise, reverse the step, 横向对折 -> 对角对折,
public class Solution {
    public void Rotate(int[,] matrix) {
        int m = matrix.GetLength(0);
        int n = matrix.GetLength(1);
        // 先对角对折
        for (int i = 0; i < m; i++) {
            for (int j = i; j < n; j++) {
                int temp = matrix[i, j];
                matrix[i, j] = matrix[j, i];
                matrix[j, i] = temp;
            }
        }
        // 再横向对折
        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n / 2; j++) {
                int temp = matrix[i, j];
                matrix[i, j] = matrix[i, n - j - 1];
                matrix[i, n - j - 1] = temp;
            }
        }
    }
}