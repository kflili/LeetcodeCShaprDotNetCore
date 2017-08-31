// recursion
// for sum, bit add only has 4 cases: 
//       1 + 0, 0 + 1, 0 + 0, 1 + 1
// a+b:  1      1      0      0 (need add 1 carry before this bit)
// a^b:  1      1      0      0 (almost the same to a+b, only no carry info)
// a&b:  0      0      0      1 (by a&b << 1 we can get carry info)
// so a+b = a^b + (a&b)<<1
// a^b + (a&b)<<1 may also has 1:1 case, generate carry, so do recursion.
public class Solution {
    public int GetSum(int a, int b) {
        if (a == 0) return b;
        if (b == 0) return a;
        return GetSum(a ^ b, (a & b) << 1);
    }
}

// for substract
// for substract, bit add only has 4 cases: 
//       1-1,   0-0,   1-0,   0-1
// a     1      0      1      0
// b     1      0      0      1
// a-b:  0      0      1      1 (need borrow 1 before this bit)
// a^b:  0      0      1      1 (almost the same to a-b, only no borrow info)
//~a     0      1      0      1   
// a&b:  0      0      0      1 (by a&b << 1 we can get borrow info)
// so a-b = a^b - ((~a)&b)<<1
// a^b - ((~a)&b)<<1 may also has 0:1 case, generate borrow, so do recursion.
public class Solution {
    public int GetSubtract(int a, int b) {
        if (b == 0) return a;
        return GetSubtract(a ^ b, (~a & b) << 1);
    }
}



// iteration
public class Solution {
    public int GetSum(int a, int b) {
        if (a == 0) return b;
        if (b == 0) return a;
        while (b != 0) {
            int carry = a & b;
            a = a ^ b;
            b = carry << 1;
        }
        return a;
    }
}

public class Solution {
    public int GetSubtract(int a, int b) {
        while (b != 0) {
            int borrow = (~a) & b;
            a = a ^ b;
            b = borrow << 1;
        }
        return a;
    }
}