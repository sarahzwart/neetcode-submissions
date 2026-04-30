public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int n = temperatures.Length; // length of temperatures
        int[] arr = new int[n]; // new array that is the length of tmperatures
        for(int i = n - 2 ; i >= 0; i--){ // going backwards start at second to last and go back
            int j = i + 1; // start j at right after i
            // if j is less than the length of the array and
            // the next day's temperature is NOT warmer than current day's
            // As long as I haven’t gone out of bounds and the current day j is not warmer than day i, jump to next warmest day
            while(j < n && temperatures[j] <= temperatures[i]){ 
                // if arr[j] == 0, it means there is NO warmer day after day j
                // so there cannot be a warmer day for day i either → stop searching
                if(arr[j] == 0){ 
                    j = n;
                    break;
                }
                j += arr[j]; // skip directly to the next possible warmer day
            }

            // if j is still within bounds, we found a warmer day
            if(j < n) {
                arr[i] = j - i; // store how many days it took
            }
            // else arr[i] stays 0 (no warmer day exists)
        }
        return arr;
    }
}
