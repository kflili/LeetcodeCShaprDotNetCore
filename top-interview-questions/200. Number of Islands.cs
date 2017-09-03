// recursion with dfs, easy solution but not typical for these bfs problem
public class Solution {
    private int m, n;
    public int NumIslands(char[,] grid) {
        m = grid.GetLength(0);
        n = grid.GetLength(1);
        if (m == 0 || n == 0) return 0;
        int count = 0;
        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                if (grid[i,j] == '1') {
                    count++;
                    DfsFill(grid, i, j);
                }
            }
        }
        return count;
    }
    private void DfsFill(char[,] grid, int i, int j) {
        // fill the point with label '1' and inside range
        if (i >=0 && i < m && j >=0 && j < n && grid[i,j] == '1') {
            grid[i, j] = '0';
            DfsFill(grid, i + 1, j);
            DfsFill(grid, i - 1, j);
            DfsFill(grid, i, j + 1);
            DfsFill(grid, i, j - 1);
        }
    }
}

// BFS, recursion
public class Solution {
    private int m, n;
    public int NumIslands(char[,] grid) {
        m = grid.GetLength(0);
        n = grid.GetLength(1);
        if (m == 0 || n == 0) return 0;
        int count = 0;
        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                if (grid[i,j] == '1') {
                    count++;
                    BfsFill(grid, i, j);
                }
            }
        }
        return count;
    }
    class Point {
        public int x, y;
        public Point(int x, int y) {
            this.x = x;
            this.y = y;
        }
    }
    private void BfsFill(char[,] grid, int x, int y) {
        int[] deltaX = { 1, -1, 0, 0 };
        int[] deltaY = { 0, 0, 1, -1 };

        Queue<Point> q = new Queue<Point>();
        q.Enqueue(new Point(x, y));
        grid[x, y] = '0';
        while (q.Count > 0) {
            Point point1 = q.Dequeue();
            for (int i = 0; i < 4; i++) {
                Point adj = new Point(
                    point1.x + deltaX[i],
                    point1.y + deltaY[i]
                );
                if (adj.x >= 0 && adj.x < m
                    && adj.y >= 0 && adj.y < n 
                    && grid[adj.x, adj.y] == '1') {
                    grid[adj.x, adj.y] = '0';
                    q.Enqueue(adj);
                }
            }
        }
    }
}