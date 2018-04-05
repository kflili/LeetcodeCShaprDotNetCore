public class Solution {
    /*
        Requirements for atoi:
        1. trim whitespace
        2. takes an optional '+' or '-'
        3. when meet non-numetic char, break " - 0012a43" return -12
        4. If no valid conversion could be performed, 0 is returned.
        5. If out of int range, return INT_MAX(2147483647) or INT_MIN(-2147483648)
        */

    private static readonly int maxDiv10 = int.MaxValue / 10;
    public int MyAtoi(string str)
    {
        if (str == null) return 0;
        int i = 0, n = str.Length;
        // while (i < n && char.IsWhiteSpace(str[i])) i++;
        while (i < n && str[i] == ' ') i++;
        if (i == n) return 0;
        int sign = 1;
        if (i < n && str[i] == '+') {
            i++;
        } else if (i < n && str[i] == '-') {
            sign = -1;
            i++;
        }
        int num = 0;
        while (i < n && char.IsDigit(str[i])) { // can use str[i] >= '0' and str[i] <= '9' to check IsDigit
            int digit = str[i] - '0';
            if (num > maxDiv10 || num == maxDiv10 && digit >= 8) {
                return sign == 1 ? int.MaxValue : int.MinValue;
            }
            num = num * 10 + digit;
            i++;
        }
        return sign * num;
    }
}

/*
Next challenges: 
Reverse Integer
Valid Number
 */