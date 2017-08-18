using System;

namespace LeetcodeCShaprDotNetCore {
    class Program {
        static void Main(string[] args) {
            var s = new Solution();
            var r = s.TwoSum(new int[] { 11, 7, 2, 15 }, 9);
            System.Console.WriteLine(r[0] + " " + r[1]);
        }
    }
}


/*
Input: numbers={2, 7, 11, 15}, target=9
Output: index1=1, index2=
*/