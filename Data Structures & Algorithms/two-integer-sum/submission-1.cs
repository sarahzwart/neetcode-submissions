public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> dict = new Dictionary<int,int>();
        for(int i = 0; i < nums.Length; i++){
            int diff = target - nums[i]; // get the difference
            if(dict.ContainsKey(diff)){ // find if the dictionary has the difference
                return new int[]{dict[diff], i}; // return the index
            }
            dict[nums[i]] = i;
        }
        return new int[0];
    }
}
