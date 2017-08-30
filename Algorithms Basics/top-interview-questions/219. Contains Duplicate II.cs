// direct idea with Dictionary
public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        if (nums == null || nums.Length < 2) {
            return false;
        }
        var dict = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++) {
            var num = nums[i];
            if (dict.ContainsKey(num)) {
                if (i - dict[num] <= k) return true;
                else dict[num] = i;
            } else {
                dict.Add(num, i);
            }
        }
        return false;
    }
}

// sliding window, faster than dictionary
/*
It iterates over the array using a sliding window. The front 
of the window is at i, the rear of the window is k steps back. 
The elements within that window are maintained using a set. 
While adding new element to the set, if add() returns false, 
it means the element already exists in the set. At that point, 
we return true. If the control reaches out of for loop, 
it means that inner return true never executed, meaning no 
such duplicate element was found.
 */

public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        if (nums == null || nums.Length < 2) {
            return false;
        }
        HashSet<int> set = new HashSet<int>();
        for (int i = 0; i < nums.Length; i++) {
            if (i > k) set.Remove(nums[i - k - 1]);
            if (!set.Add(nums[i])) return true;
        }
        return false;
    }
}