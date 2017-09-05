/*
 the most straightforward way is to use quick select. 
 There is a simple conversion: Find kith largest element is equivalent to 
 find (n - k)th smallest element in array. 
 It is worth mentioning that (n - k) is the real index (start from 0) of an element.
example: 1st largest, index shouble be n-1 index in sorted array.
 */
public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        int start = 0, end = nums.Length - 1, index = nums.Length - k;
        while (start < end) {
            int pivot = Partion(nums, start, end);
            if (pivot < index) start = pivot + 1;
            else if (pivot > index) end = pivot - 1;
            else return nums[pivot];
        }
        return nums[start];
    }
    private int Partion(int[] nums, int start, int end) {
        int pivot = start;
        while (start <= end) {
            while (start <= end && nums[start] <= nums[pivot]) start++;
            while (start <= end && nums[end] > nums[pivot]) end--;
            if (start > end) break;
            Swap(nums, start, end);
        }
        Swap(nums, pivot, end);
        return end;
    }
    private void Swap(int[] nums, int i, int j) {
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }
}