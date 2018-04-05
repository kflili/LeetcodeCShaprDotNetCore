using System;
using System.Collections.Generic;
namespace LeetcodeCShaprDotNetCore {
    class Program {
        static void Main(string[] args) {
            var t = new int[] { 2147483647 };
            var t2 = new Solution().FindMissingRanges(t, 0, 2147483647);

            Console.ReadLine();
        }

    }
}
