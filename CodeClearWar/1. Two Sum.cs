/*
Solution tip: 
    Just use dictionary. For each cur = nums[i], check if complement = target-nums[i] exists in the dictionary.
    if exists, return (dic[complement], i);
    if not, put cur into dictionary.

The core approach for all the two sums, is re-mapping the <key,value>.

1. Before re-mapping, if we need find a value(target - cur) in the nums[i], we should iterate all the items, O(n);
2. For re-mapping, we create a dictinary with sapce O(n), then set the value as key, the index i as value.
3. After re-mapping, if we need find the  key, value(target - cur), in dictionary, we just need O(1) time 
to get the value, index.

That's it! Just do re-mapping, trade off is O(n) space vs O(n) time.
The solution is 
    O(n) runtime, O(n) space
 */
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var dict = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++) {
            var cur = nums[i];
            var complement = target - cur;
            if (dict.ContainsKey(complement)) {
                return result = new int[] { dict[complement], i };
            }
            dict[cur] = i;
        }
        throw new Exception("No two sum solution");
    }
}

/*
Similar Questions or Next challenges:
3Sum
4Sum
Two Sum II - Input array is sorted
Two Sum III - Data structure design
Subarray Sum Equals K
Two Sum IV - Input is a BST
 */