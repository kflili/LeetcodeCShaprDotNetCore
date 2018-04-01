using System;
using System.Collections.Generic;
using System.Text;

namespace LeetcodeCShaprDotNetCore
{

    public class Solution
    {
        private static readonly int maxDiv10 = int.MaxValue / 10;
        public static int MyAtoi(string str)
        {
            int i = 0, n = str.Length;
            while (i < n && char.IsWhiteSpace(str[i])) i++;
            int sign = 1;
            if (i < n && str[i] == '+') {
                i++;
            }
            else if (i < n && str[i] == '-')
            {
                sign = -1;
                i++;
            }
            int num = 0;
            while (i < n && char.IsDigit(str[i]))
            {
                int digit = str[i] - '0';
                if (num > maxDiv10 || num == maxDiv10 && digit >= 8)
                {
                    return sign == 1 ? int.MaxValue : int.MinValue;
                }
                num = num * 10 + digit;
                i++;
            }
            return sign * num;
        }
    }
}