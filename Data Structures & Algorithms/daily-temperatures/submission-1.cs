public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int n = temperatures.Length;
        int[] arr = new int[n];
        for(int i = n - 2 ; i >= 0; i--){
            int j = i + 1;
            while(j < n && temperatures[j] <= temperatures[i]){
                if(arr[j] == 0){
                    j = n;
                    break;
                }
                j += arr[j];
            }

            if(j < n) {
                arr[i] = j - i;
            }
        }
        return arr;
    }
}
