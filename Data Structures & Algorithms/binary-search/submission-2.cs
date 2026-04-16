public class Solution {
    public int Search(int[] nums, int target) {
        int l = 0, r = nums.Length - 1;
        while(l < r){
            int mid = l + ((r-l)/2);
            if(target <= nums[mid]){
                r = mid;
            } else {
                l = mid + 1;
            }
        }
        return (l < nums.Length && nums[l] == target) ? l : -1;
        
    }
}