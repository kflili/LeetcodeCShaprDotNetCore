public class TwoSum {

    private List<int> list;
    
    /** Initialize your data structure here. */
    public TwoSum() {
        this.list = new List<int>();
    }
    /** Add the number to an internal data structure.. */
    public void Add(int number) {
        list.Add(number);
    }
    /** Find if there exists any pair of numbers which sum is equal to the value. */
    public bool Find(int value) {
        if (list == null || list.Count < 2) {
            return false;
        }
        var set = new HashSet<int>();
        for (int i = 0; i < list.Count; i++) {
            var cur = list[i];
            var completement = value - cur;
            if (set.Contains(completement)) {
                return true;
            }
            set.Add(cur);
        }
        return false;
    }
}

/**
 * Your TwoSum object will be instantiated and called as such:
 * TwoSum obj = new TwoSum();
 * obj.Add(number);
 * bool param_2 = obj.Find(value);
 */