// find each nearby peak , valley
public class Solution {
    public int MaxProfit(int[] prices) {
        if (prices == null || prices.Length < 2) {
            return 0;
        }
        int i = 0;
        int valley = prices[0];
        int peak = prices[0];
        int maxProfit = 0;
        while (i < prices.Length - 1) {
            // find valley
            while (i < prices.Length - 1 && prices[i] >= prices[i + 1]){
                i++;
            }
            valley = prices[i];
            // find peak
            while (i < prices.Length - 1 && prices[i] <= prices[i + 1]) {
                i++;
            }
            peak = prices[i];
            maxProfit += peak - valley;
        }
        return maxProfit;
    }
}

// if shape a ->b->c->d keep increasing, a as valley, d is peak, 
// d - a = d- c + c - b + b -a;
// so we don't need find exact peak d, just use d-c, c -b, b -a. then Sum.
public class Solution {
    public int MaxProfit(int[] prices) {
        if (prices == null || prices.Length < 2) {
            return 0;
        }
        int maxProfit = 0;
        for (int i = 1; i < prices.Length; i++) {
            if (prices[i] > prices[i - 1]) {
                maxProfit += prices[i] - prices[i - 1];
            }
        }
        return maxProfit;
    }
}