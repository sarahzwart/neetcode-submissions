public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> vals = new HashSet<int>();
        foreach(int n in nums){
            if(vals.Contains(n)){
                return true;
            }
            vals.Add(n);
        }
        return false;
    }
}