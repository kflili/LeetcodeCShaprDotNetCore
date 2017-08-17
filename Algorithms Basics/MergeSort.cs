public class Solution {
    public void SortIntegers2(int[] A) {
        int[] temp = new int[A.Length];
        MergeSort(A, 0, A.Length - 1, temp);
    }
    private void MergeSort(int[] A, int start, int end, int[] temp) {
        if (start >= end) {
            return;
        }
        int mid = start + (end - start) / 2;
        MergeSort(A, start, mid, temp);
        MergeSort(A, mid + 1, end, temp);
        Merge(A, start, mid, end, temp);
    }
    private void Merge(int[] A, int start, int mid, int end, int[] temp) {
        int left = start;
        int right = mid + 1;
        int index = start;
        // merge two sorted subarrays in A to temp array
        while (left <= mid && right <= end) {
            if (A[left] < A[right]) {
                temp[index++] = A[left++];
            } else {
                temp[index++] = A[right++];
            }
        }
        while (left <= mid) {
            temp[index++] = A[left++];
        }
        while (right <= end) {
            temp[index++] = A[right++];
        }
        // copy temp back to A
        for (int i = start; i <= end; i++) {
            A[i] = temp[i];
        }
    }
}