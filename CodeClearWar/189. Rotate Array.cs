/*
Approach #4 Using Reverse [Accepted]
Algorithm

This approach is based on the fact that when we rotate the array k times, k elements from 
the back end of the array come to the front and the rest of the elements from the front shift backwards.

In this approach, we firstly reverse all the elements of the array. Then, reversing the 
first k elements followed by reversing the rest n-k elements gives us the required result.

"double reverse tech"
Complexity Analysis

Time complexity : O(n). nn elements are reversed a total of three times.

Space complexity : O(1). No extra space is used.
 */
public class Solution {
    public void Rotate(int[] nums, int k) {
        if (nums == null || nums.Length == 0 || k % nums.Length == 0) return;
        k %= nums.Length;
        Reverse(nums, 0, nums.Length - 1);
        Reverse(nums, 0, k - 1);
        Reverse(nums, k, nums.Length - 1);
    }
    private void Reverse(int[] nums, int start, int end) {
        while (start < end) {
            var temp = nums[start];
            nums[start] = nums[end];
            nums[end] = temp;
            start++;
            end--;
        }
    }
}

/*
Approach #1 Brute Force [Time Limit Exceeded]
The simplest approach is to rotate all the elements of the array in k steps by rotating 
the elements by 1 unit in each step.
O(n*k) runtime, O(1) sapce. No extra space is used.
 */
public class Solution {
    public void Rotate(int[] nums, int k) {
        int temp, previous;
        for (int i = 0; i < k; i++) {
            previous = nums[nums.Length - 1];
            for (int j = 0; j < nums.Length; j++) {
                temp = nums[j];
                nums[j] = previous;
                previous = temp;
            }
        }
    }
}

/*
Approach #2 Using Extra Array [Accepted]
We use an extra array in which we place every element of the array at its 
correct position i.e. the number at index ii in the original array is placed 
at the index (i+k). Then, we copy the new array to the original one.

O(n) runtime. One pass is used to put the numbers in the new array. And another pass 
to copy the new array to the original one.

O(n) space. Another array of the same size is used.

 */

public class Solution {
    public void Rotate(int[] nums, int k) {
        int[] a = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++) {
            a[(i + k) % nums.Length] = nums[i];
        }
        for (int i = 0; i < nums.Length; i++) {
            nums[i] = a[i];
        }
    }
}

/*
Approach #3 Using Cyclic Replacements [Accepted]
Complexity Analysis
Time complexity : O(n). Only one pass is used.
Space complexity : O(1). Constant extra space is used.
 */
public class Solution {
    public void Rotate(int[] nums, int k) {
        k = k % nums.Length;
        int count = 0;
        for (int start = 0; count < nums.Length; start++) {
            int current = start;
            int prev = nums[start];
            do {
                int next = (current + k) % nums.Length;
                int temp = nums[next];
                nums[next] = prev;
                prev = temp;
                current = next;
                count++;
            } while (start != current); // current will finally meet start, the least common multiple of k and n
        }
    }
}

/*
Similar Questions 
Rotate List
Reverse Words in a String II
 */