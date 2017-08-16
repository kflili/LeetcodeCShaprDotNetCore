class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        if (nums == null || nums.Length == 0)
        {
            return 0;
        }
        int slow = 0;
        for (int fast = 0; fast < nums.Length; fast++)
        {
            if (nums[fast] != val)
            {
                nums[slow++] = nums[fast];
            }
        }
        return slow;
    }
}