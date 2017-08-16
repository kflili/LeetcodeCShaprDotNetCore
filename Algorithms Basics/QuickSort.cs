public void QuickSort(int[] array) {
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