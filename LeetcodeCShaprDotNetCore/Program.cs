using System;
using System.Collections.Generic;
namespace LeetcodeCShaprDotNetCore {
    class Program {
        static void Main(string[] args) {
            var solution = new Solution2();
            var s1 = "abab";
            var s2 = "aba";
            var s3 = "abcabcabcabc";
            System.Console.WriteLine(solution.RepeatedSubstringPattern(s1));
            System.Console.WriteLine(solution.RepeatedSubstringPattern(s2));
            System.Console.WriteLine(solution.RepeatedSubstringPattern(s3));
        }
    }
}


/*
Given "abcabcbb", the answer is "abc", which the length is 3.

Given "bbbbb", the answer is "b", with the length of 1.

Given "pwwkew", the answer is "wke", with the length of 3. 
Note that the answer must be a substring, "pwke" is a subsequence and not a substring.
 */