public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> track = new HashSet<int>();
        foreach(int n in nums){
            if(track.Contains(n)){
                return true;
            }
            track.Add(n);
        }
        return false;
    }
}