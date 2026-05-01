public class Solution {
    public int MaxProfit(int[] prices) {
        int minV = prices[0]; 
        int maxP = 0;
        foreach(int p in prices){
            minV = Math.Min(p, minV);
            maxP = Math.Max(p - minV, maxP);
        }
        return maxP;
    }
}
