public class Solution {
    /**
     * @param A an integer array
     * @return void
     */
    public void sortIntegers2(int[] A) {
        quickSort(A, 0, A.length - 1);
    }
    
    private void quickSort(int[] A, int start, int end) {
        if (start >= end) {
            return;
        }
        
        int left = start, right = end;
        // key point 1: pivot is the value, not the index
        int pivot = A[(start + end) / 2];

        // key point 2: every time you compare left & right, it should be 
        // left <= right not left < right
        while (left <= right) {
            // key point 3: A[left] < pivot not A[left] <= pivot
            while (left <= right && A[left] < pivot) {
                left++;
            }
            // key point 3: A[right] > pivot not A[right] >= pivot
            while (left <= right && A[right] > pivot) {
                right--;
            }
            if (left <= right) {
                int temp = A[left];
                A[left] = A[right];
                A[right] = temp;
                
                left++;
                right--;
            }
        }
        
        quickSort(A, start, right);
        quickSort(A, left, end);
    }
}


// with reformat method
public void SortInteger2(int[] array) {
    QuickSort(array, 0, array.Length - 1);
}
public void QuickSort(int[] array, int start, int end) {
    if (start >= end) {
        return;
    }
    int pivot = array[start + (end - start) / 2];
    int index = Partition(array, start, end, pivot);
    QuickSort(array, start, index - 1);
    QuickSort(array, index, end);
}
private int Partition(int[] array, int left, int right, int pivot) {
    while (left <= right) {
        while (left <= right && array[left] < pivot) {
            left++;
        }
        while (left <= right && array[right] > pivot) {
            right--;
        }
        if (left <= right) {
            Swap(array, left, right);
            left++;
            right--;
        }
    }
    return left;
}
private void Swap(int[] array, int left, int right) {
    var temp = array[left];
    array[left] = array[right];
    array[right] = temp;
}