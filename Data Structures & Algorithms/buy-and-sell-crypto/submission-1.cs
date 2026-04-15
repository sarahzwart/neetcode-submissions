public class Solution {
    public int MaxProfit(int[] prices) {
        int maxP = 0;
        int minV = prices[0];

        foreach(int val in prices){
            maxP = Math.Max(maxP, val - minV);
            minV = Math.Min(val, minV);
        }
        return maxP;
    }
}
