public class Solution {
    public int MaxProfit(int[] prices) {
        int maxP = 0; 
        int minVal = prices[0];

        foreach(int p in prices){
            maxP = Math.Max(maxP, p - minVal);
            minVal = Math.Min(p, minVal);
        }
        return maxP;
    }
}
