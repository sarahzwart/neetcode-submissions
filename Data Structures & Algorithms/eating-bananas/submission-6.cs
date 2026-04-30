public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int left = 1;
        int right = piles.Max(); // maximum pile size

        // Helper: can we finish with speed k?
        bool CanFinish(int k) {
            long hours = 0;
            foreach (int p in piles) {
                // hours for this pile: ceil(p / k) = (p + k - 1) / k
                hours += (p + k - 1) / k;
                if (hours > h) return false; // early exit
            }
            return hours <= h;
        }

        // Binary search for the smallest k that works
        while (left < right) {
            int mid = left + (right - left) / 2;
            if (CanFinish(mid)) {
                right = mid;
            } else {
                left = mid + 1;
            }
        }

        return left;
    }
}
