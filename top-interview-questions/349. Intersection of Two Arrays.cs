// HashSet
public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        HashSet<int> set = new HashSet<int>();
        HashSet<int> intersect = new HashSet<int>();
        foreach (var num in nums1) {
            set.Add(num);
        }
        foreach (var n in nums2) {
            if (set.Contains(n)) {
                intersect.Add(n);
            }
        }
        int[] result = new int[intersect.Count];
        int i = 0;
        foreach(var item in intersect) {
            result[i++] = item;
        }
        return result;
    }
}

// two pointers
public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        HashSet<int> set = new HashSet<int>();
        Array.Sort(nums1);
        Array.Sort(nums2);
        int i = 0;
        int j = 0;
        while (i < nums1.Length && j < nums2.Length) {
            if (nums1[i] < nums2[j]) {
                i++;
            } else if (nums1[i] > nums2[j]) {
                j++;
            } else {
                set.Add(nums1[i]);
                i++;
                j++;
            }
        }
        int[] result = new int[set.Count];
        int k = 0;
        foreach (var num in set) {
            result[k++] = num;
        }
        return result;
    }
}

// Binary search
public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        HashSet<int> set = new HashSet<int>();
        Array.Sort(nums2);
        foreach (var num in nums1) {
            if (BinarySearch(nums2, num)) {
                set.Add(num);
            }
        }
        int i = 0;
        int[] result = new int[set.Count];
        foreach (var num in set) {
            result[i++] = num;
        }
        return result;
    }

    public bool BinarySearch(int[] nums, int target) {
        int low = 0;
        int high = nums.Length - 1;
        while (low <= high) {
            int mid = low + (high - low) / 2;
            if (nums[mid] == target) {
                return true;
            }
            if (nums[mid] > target) {
                high = mid - 1;
            } else {
                low = mid + 1;
            }
        }
        return false;
    }
}