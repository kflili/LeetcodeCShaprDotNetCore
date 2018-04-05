/*
Example Questions Candidate Might Ask:
Q: What if the given array is empty?
A: Then you should return [“0->99”] as those ranges are missing.
Q: What if the given array contains all elements from the ranges?
A: Return an empty list, which means no range is missing.

As it turns out, if we could add two “artificial” elements, –1 before the first element and
100 after the last element, we could avoid all the above pesky cases.

This question is about what you have and what you should have. lower and upper is what you 
should have, nums is what you have. By changing lower to lower - 1, and upper to upper + 1, 
we converted all our data to what you have. (because you should have lower, but we “have” lower-1)

Now, loop through all we have, that is [lower-1 --> nums --> upper+1], and properly record all 
gaps between two consecutive numbers, if necessary.
 */

public class Solution {
    public IList<string> FindMissingRanges(int[] nums, int lower, int upper) {
        var res = new List<string>();
        long prev = (long)lower - 1;
        long curr = 0;
        for (int i = 0; i <= nums.Length; i++) {
            curr = (i == nums.Length) ? (long)upper + 1 : nums[i];
            if (prev + 2 == curr) {
                res.Add(prev + 1 + "");
            } else if (prev + 2 < curr) {
                res.Add(prev + 1 + "->" + (curr - 1));
            }
            prev = curr;
        }
        return res;
    }
}

/*
Next challenges: 
Summary Ranges
 */