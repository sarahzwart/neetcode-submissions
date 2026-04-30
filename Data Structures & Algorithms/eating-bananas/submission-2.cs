public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int l = 1;
        int r = piles.Max();
        int ret = r;

        while(l <= r){
            int k = (l + r) / 2;

            long totalT = 0;
            foreach (int p in piles) {
                totalT += (int)Math.Ceiling((double)p/k);
            }
            if(totalT > h){
                l = k + 1;
            } else {
                ret = k;
                r = k - 1;
            }
        }
        return ret;
    }
}
