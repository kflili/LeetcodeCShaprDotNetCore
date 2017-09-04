/* method 1: count sort
 first loop to get count array. count[0], count[1], count[2]
second loop fill the array with related numbers
*/

/* method 2: two pointer. (core algrighm is quick sort)
two pointer and 1 scanner. 
when scanner meet 0, swap with left,
                  1, keep moving scan,
                  2, swap with right
 */

public class Solution {
    public void SortColors(int[] nums) {
        if (nums == null || nums.Length == 0) return;
        int redIndex = 0;
        int blueIndex = nums.Length - 1;
        int i = 0;
        while (i <= blueIndex) {
            if (nums[i] == 0) {
                Swap(nums, redIndex, i);
                redIndex++;
                i++;
            } else if (nums[i] == 1) {
                i++;
            } else {
                Swap(nums, i, blueIndex);
                blueIndex--;
            }
        }
    }
    private void Swap(int[] nums, int i, int j) {
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }
}

// rainbow sort, general idea for k colors
class Solution {
    /**
     * @param colors: A list of integer
     * @param k: An integer
     * @return: nothing
     */
    public void sortColors2(int[] colors, int k) {
        // write your code here
        if (colors == null || colors.length < 2) {
            return;
        }
        rainbowSort(colors, 0, colors.length - 1, 1, k);
    }
    private void rainbowSort(int[] colors, int left, int right, int colorFrom,
                            int colorTo) {
        if (left >= right) {
            return;
        }
        if (colorFrom == colorTo) {
            return;
        }
        int midColor = (colorFrom + colorTo) / 2;
        int l = left, r = right;
        while (l <= r) {
            while (l <= r && colors[l] <= midColor) {
                l++;
            }
            while (l <= r && colors[r] > midColor) {
                r--;
            }
            if (l < r) {
                int temp = colors[l];
                colors[l] = colors[r];
                colors[r] = temp;
                l++;
                r--;
            }
        }
        rainbowSort(colors, left, r, colorFrom, midColor);
        rainbowSort(colors, l, right, midColor + 1, colorTo);
    }
}