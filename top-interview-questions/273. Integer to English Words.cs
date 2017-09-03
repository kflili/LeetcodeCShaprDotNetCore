public class Solution {
    public string NumberToWords(int num) {
        if (num == 0) return "Zero";
        string[] lessThan20Words = { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
        string[] tyWords = { "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
        string[] dexWords = { "Billion", "Million", "Thousand", "Hundred" };
        int[] radix = { 1000000000, 1000000, 1000, 100 };
        StringBuilder sb = new StringBuilder();
        int count = 0;
        for (int i = 0; i < radix.Length; i++) {
            count = num / radix[i];
            if (count == 0) continue;
            sb.Append(NumberToWords(count) + " ");
            sb.Append(dexWords[i] + " ");
            num %= radix[i];
        }
        if (num < 20) {
            sb.Append(lessThan20Words[num] + " ");
        } else {
            sb.Append(tyWords[num / 10 - 2] + " ");
            sb.Append(lessThan20Words[num % 10]);
        }
        return sb.ToString().Trim();
    }
}