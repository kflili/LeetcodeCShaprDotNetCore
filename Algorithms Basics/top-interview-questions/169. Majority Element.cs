// method 1: Array.sort and then check nums[n/2];
// method 2: use Dictionary

// method 3: Moore voting algorithm
public class Solution {
    public int MajorityElement(int[] nums) {
        int count = 0, major = 0;
        foreach (int num in nums) {
            if (count == 0) {
                major = num;
                count++;
            } else if (num != major) {
                count--;
            } else {
                count++;
            }
        }
        return major;
    }
}

// method 4 count bits and recostructor, not good for code, just brain teaser