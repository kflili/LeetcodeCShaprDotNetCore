
/* 
Solution:
This problem is very similar to Question [8. String to Integer (atoi)]. Due to many corner
cases, it is helpful to break the problem down to several components that can be solved
individually.
A string could be divided into these four substrings in the order from left to right:
s1. Leading whitespaces (optional).
s2. Plus (+) or minus (–) sign (optional).
s3. Number.
s4. Optional trailing whitespaces (optional).

On the other hand, a decimal number could be further divided into three parts:
a. Integer part
b. Decimal point
c. Fractional part

A number could contain an optional exponent part, which is marked by a character ‘e’
followed by a whole number (exponent). For example, “1e10” is numeric. Modify the
above code to adapt to this new requirement.

 */
public class Solution {
    public bool IsNumber(string s) {
        int i = 0, n = s.Length;
        while (i < n && s[i] == ' ') i++;
        if (i < n && (s[i] == '+' || s[i] == '-')) i++;
        bool isNumeric = false;
        while (i < n && (s[i] >= '0' && s[i] <= '9')) {
            i++;
            isNumeric = true;
        }
        // decimal part
        if (i < n && s[i] == '.') {
            i++;
            while (i < n && (s[i] >= '0' && s[i] <= '9')) {
                i ++;
                isNumeric = true;
            }
        }
        // exponent part
        if (isNumeric && i < n && s[i] == 'e') {
            i++;
            isNumeric = false;
            if (i < n && (s[i] == '+' || s[i] == '-')) i++;
            while (i < n && (s[i] >= '0' && s[i] <= '9')) {
                i ++;
                isNumeric = true;
            }
        }
        while (i < n && s[i] == ' ') i++;
        return isNumeric && i == n;
    }
}

/*
Next challenges: 
Edit Distance
Judge Route Circle
Maximum Swap

 */