/*
Q: What if the given array is already sorted? How would you 
optimize your algorithm?
A: If both arrays are sorted, I would use two pointers to 
iterate, which somehow resembles the merge process in merge sort.

Q: What if nums1's size is small compared to nums2's size? 
Which algorithm is better?
A: Suppose lengths of two arrays are N and M, the time complexity 
of my solution is O(N+M) and the space complexity if O(N) 
considering the hash. So it's better to use the smaller array 
to construct the counter hash. Well, as we are calculating the 
intersection of two arrays, the order of array doesn't matter. 
We are totally free to swap to arrays.

Q: What if elements of nums2 are stored on disk, and the memory 
is limited such that you cannot load all elements into the memory 
at once?
A: Divide and conquer. Repeat the process frequently: Slice nums2 to fit into memory, process (calculate intersections), and write partial results to memory. */

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