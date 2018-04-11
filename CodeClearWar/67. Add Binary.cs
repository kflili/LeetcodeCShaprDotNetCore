public class Solution {
    public string AddBinary(string a, string b) {
        StringBuilder sb = new StringBuilder();
        int i = a.Length - 1, j = b.Length - 1, carry = 0;
        while (i >= 0 || j>=0) {
            int sum = carry;
            if (i >= 0) sum += a[i--] - '0';
            if (j >= 0) sum += b[j--] - '0';
            // keep get the digit, and insert to left site
            sb.Insert(0, sum % 2);  // sum % 2 get the digit,
            carry = sum / 2;    // sum / 2 get the carry for adding to left bit
        }
        if (carry > 0) sb.Insert(0, carry);
        return sb.ToString();
    }
}

/*
Next challenges: 
Add Two Numbers
Multiply Strings
 */