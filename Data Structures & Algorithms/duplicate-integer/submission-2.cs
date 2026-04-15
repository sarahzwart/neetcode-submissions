public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> hasNum = new HashSet<int>();
        foreach (int num in nums){
            if (hasNum.Contains(num)){
                return true;
            }
            hasNum.Add(num);
        }
        return false;
    }
}