// sort array, then loop each index, do 2Sum in [index + 1, ..., end]
public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        IList<IList<int>> res = new List<IList<int>>();
        if (nums == null || nums.Length < 3) return res;
        Array.Sort(nums);
        for (int i = 0; i < nums.Length - 2; i++) {
            if (i > 0 && nums[i] == nums[i - 1]) continue;
            int l = i + 1, r = nums.Length - 1;
            int target = 0 - nums[i];
            while (l < r) {
                int v = nums[l] + nums[r];
                if (v < target) {
                    l++;
                } else if (v > target) {
                    r--;
                } else {
                    res.Add(new List<int>() { nums[i], nums[l], nums[r] });
                    while (l < r && nums[l] == nums[l + 1]) l++;
                    while (l < r && nums[r] == nums[r - 1]) r--;
                    l++;
                    r--;
                }
            }
        }
        return res;
    }
}

// abstract TwoSum method
public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        var results = new List<IList<int>>();
        if (nums == null || nums.Length < 3) return results;
        Array.Sort(nums);
        for (int i = 0; i < nums.Length - 2; i++) {
            if (nums[i] > 0) return results;
            if (i > 0 && nums[i] == nums[i - 1]) continue;
            var left = i + 1;
            var right = nums.Length - 1;
            var target = 0 - nums[i];
            TwoSum(nums, left, right, target, results);
        }
        return results;
    }
    
    private void TwoSum(int[] nums, int left, int right, int target, List<IList<int>> results) {
        while (left < right) {
            var v = nums[left] + nums[right];
            if (v < target) left++;
            else if (v > target) right--;
            else {
                results.Add(new List<int>(){-target, nums[left], nums[right]});
                while (left < right && nums[left] == nums[left + 1]) left++;
                while (left < right && nums[right] == nums[right - 1]) right--;
                left++;
                right--;
            }
        }
    }
}

/*
Next challenges: 
3Sum Closest
4Sum
3Sum Smaller
 */