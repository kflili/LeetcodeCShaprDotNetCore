# Leetcode C# solution and notes

I will use this repository to make notes for leetcode solutions and sort similar questions into the same group or category.

First, I will start from the very basic and useful part. The Leetcode Course Section, which is selected interview questions aimed for beginners who do not know algorithms or need a refresher. Learn by doing.

## Algorithms Basics

### Chapter 1. Array / String

#### 26. Remove Duplicates from Sorted Array

This problem can be solved by typical double pointer technique.

**Algorithm**
Since the array is already sorted, we can keep two pointers *slow* and *fast*. As long as nums[*fast*] = nums[*slow*], we increse *fast* to skip the duplicate.

When we encounter nums[*fast*] != nums[*slow*], the duplicate run has ended so we must copy its value to nums[*slow* + 1]. ii is then incremented and we repeat the same process again until *fast* reaches the end of array.
The core part for the solution code is as below:

```csharp
class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        if (nums == null || nums.Length == 0)
        {
            return 0;
        }
        int slow = 0;
        for (int fast = 0; fast < nums.Length; fast++)
        {
            if (nums[fast] != nums[slow])
            {
                nums[++slow] = nums[fast];
            }
        }
        return slow + 1;
    }
}
```

Similar problems:
 >27 Remove Element; 203 Remove Linked List Elements; 283. Move Zeroes (error prone, double think for more cases)