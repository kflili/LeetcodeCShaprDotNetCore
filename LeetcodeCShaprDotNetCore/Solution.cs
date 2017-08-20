using System;
using System.Collections.Generic;
using System.Text;

namespace LeetcodeCShaprDotNetCore {
    public class Solution {
        /*
            Requirements for atoi:
            1. trim whitespace
            2. takes an optional '+' or '-'
            3. when meet non-numetic char, break " - 0012a43" return -12
            4. If no valid conversion could be performed, 0 is returned.
            5. If out of int range, return INT_MAX(2147483647) or INT_MIN(-2147483648)
         */

        public int MyAtoi(string str)
        {
            if (str == null) return 0;
            str = str.Trim();
            if (str.Length == 0) return 0;
            int sign = 1;
            int index = 0;
            if (str[index] == '+') index++;
            else if (str[index] == '-') {
                sign = -1;
                index++;
            }
            long num = 0;
            for (; index < str.Length; index++) {
                if (str[index] < '0' || str[index] > '9')
                {
                    break;
                }
                num = num * 10 + str[index] - '0';
                if (num > int.MaxValue)
                {
                    break;
                }
            }
            if (num * sign >= int.MaxValue)
            {
                return int.MaxValue;
            } 
            if (num * sign <= int.MinValue)
            {
                return int.MinValue;
            }
            return (int)num * sign;
        }
    }
}
