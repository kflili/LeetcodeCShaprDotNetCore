// core feature: num(i, j) = num(i-1, j-1) + num(i - 1, j)
public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        IList<IList<int>> result = new List<IList<int>>();
        for (int row = 0; row < numRows; row++) {
            IList<int> list = new List<int>();
            for (int i = 0; i < row + 1 ; i++) {
                if (i == 0 || i == row) {
                    list.Add(1);
                } else {
                    var preList = result[row - 1];
                    list.Add(preList[i - 1] + preList[i]);
                }
            }
            result.Add(list);
        }
        return result;
    }
}