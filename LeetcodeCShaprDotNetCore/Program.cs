using System;

namespace LeetcodeCShaprDotNetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[]{1, 1, 2};
            var s = new Solution();
            Console.WriteLine(s.RemoveDuplicates(nums));
            Console.ReadLine();
        }
    }
}
