using System;

namespace LeetcodeCShaprDotNetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[]{ 3, 2, 2, 3 };
            var s = new Solution();
            Console.WriteLine(s.RemoveElement(nums, 3));
            Console.ReadLine();
        }
    }
}
