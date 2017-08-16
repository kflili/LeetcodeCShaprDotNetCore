# Leetcode C# solution and notes

I will use this repository to make notes for leetcode solutions and sort similar questions into the same group or category.

First, I will start from the very basic and useful part. The Leetcode Course Section, which is selected interview questions aimed for beginners who do not know algorithms or need a refresher. Learn by doing.

## Algorithms Basics

### Chapter 1. Array / String

26. Remove Duplicates from Sorted Array

This problem can be solved by typical double pointer technique.
The core part for the solution code is as below:

```csharp
int slow = 0;
for (int fast = 0; fast < nums.Length; fast++)
{
    if (nums[fast] != nums[slow])
    {
        nums[++slow] = nums[fast];
    }
}
return slow + 1;
```

Similar problems:
 