using System;
using System.Collections.Generic;
namespace LeetcodeCShaprDotNetCore {
    class Program {
        static void Main(string[] args) {
            Solution s = new Solution();
            string str = "hello world!";
            string newS = s.ReverseWords(str);
            System.Console.WriteLine(newS);
        }
    }
}
