public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        // O(m * n)
        var res = new Dictionary<string, List<string>>();
        foreach(string s in strs){
            // have to track which words contain the same chars
            int[] alphaCount = new int[26];
            foreach(char c in s){
                alphaCount[c-'a']++;
            }
            string key = string.Join(' ', alphaCount);
            if(!res.ContainsKey(key)){
                res[key] = new List<string>();
            }
            res[key].Add(s);
        }
        return res.Values.ToList<List<string>>();
    }
}
