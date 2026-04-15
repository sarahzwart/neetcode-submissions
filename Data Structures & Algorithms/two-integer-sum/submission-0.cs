public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> numbers = new Dictionary<int,int>();
        for (int i = 0; i<nums.Length; i++){
            int dif = target - nums[i]; // get the difference
            if (numbers.ContainsKey(dif)){ // if it contains it then return the two
                return new int[] {numbers[dif], i};
            } 
            // else 
            numbers[nums[i]] = i; 
        }
        return null;
    }
}
