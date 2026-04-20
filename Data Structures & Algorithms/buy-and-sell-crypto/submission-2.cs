public class Solution {
    public int MaxProfit(int[] prices) {
        int maxP = 0;
        int minV = prices[0];
        foreach(int price in prices){
            maxP = Math.Max(price - minV, maxP);
            minV = Math.Min(minV, price);
        }
        return maxP;
    }
}
