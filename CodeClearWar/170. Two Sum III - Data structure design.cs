/*
Tip:
    See 1. Two sums. for the intrinsic thought and approch. re-Mapping <key, value>.
1. Add time O(1), Find time O(n), space O(n);
 */
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
        var set = new HashSet<int>();
        for (int i = 0; i < list.Count; i++) {
            var cur = list[i];
            var complement = value - cur;
            if (set.Contains(complement)) {
                return true;
            }
            set.Add(cur);
        }
        return false;
    }
}

/*
2. Add time O(n), Find time O(1), space O(n^2);
 */
public class TwoSum {
    private List<int> num;
    private HashSet<int> sum;
    
    /** Initialize your data structure here. */
    public TwoSum() {
        num = new List<int>();
        sum = new HashSet<int>();
    }
    
    /** Add the number to an internal data structure.. */
    public void Add(int number) {
        if (num.Contains(number)) {
            // no need to iterate other num for adding
            sum.Add(number * 2);
        } else {
            foreach(var v in num) {
                sum.Add(v + number);
            }
            num.Add(number);
        }
    }
    
    /** Find if there exists any pair of numbers which sum is equal to the value. */
    public bool Find(int value) {
        return sum.Contains(value);
    }
}

/*
add – O(log n) runtime, find – O(n) runtime, O(n) space – Binary search + Two
pointers:
Maintain a sorted array of numbers. Each add operation would need O(log n) time to
insert it at the correct position using a modified binary search (See Question [48. Search
Insert Position]). For find operation we could then apply the [Two pointers] approach in
O(n) runtime.

 */

/*
Next challenges:
Unique Word Abbreviation
 */