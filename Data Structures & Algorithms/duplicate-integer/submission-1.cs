public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> ht = new HashSet<int>();
        if (nums.Length <= 1){
            return false;
        }
        foreach (int n in nums){
            if(ht.Remove(n)){
                return true;
            }
            ht.Add(n);
        }
        return false;
    }
}