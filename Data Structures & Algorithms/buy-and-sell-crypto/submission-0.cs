public class Solution {
    public int MaxProfit(int[] prices) {
        int profit = 0;
        
        for (int i=0; i<prices.Length-1; i++) {
            for (int j=i+1; j<prices.Length; j++) {
                int diff = prices[j]-prices[i];
                if (prices[j]-prices[i] > profit) {
                    profit = diff;
                }
            }
        }

        return profit;
    }
}
