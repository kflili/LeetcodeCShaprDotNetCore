// Dictionary
public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        List<int> res = new List<int>();
        var dict = new Dictionary<int, int>();
        foreach(var num in nums1) {
            if (dict.ContainsKey(num)) {
                dict[num]++;
            } else {
                dict.Add(num, 1);
            }
        }
        foreach(var n in nums2) {
            if (dict.ContainsKey(n) && dict[n] > 0) {
                res.Add(n);
                dict[n]--;
            }
        }
        return res.ToArray();
    }
}

// sort two array first, then use two pointers
public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        List<int> res = new List<int>();
        Array.Sort(nums1);
        Array.Sort(nums2);
        int i = 0, j = 0;
        while (i < nums1.Length && j < nums2.Length) {
            if (nums1[i] < nums2[j]) {
                i++;
            } else if (nums1[i] > nums2[j]) {
                j++;
            } else {
                res.Add(nums1[i]);
                i++;
                j++;
            }
        }
        return res.ToArray();
    }
}