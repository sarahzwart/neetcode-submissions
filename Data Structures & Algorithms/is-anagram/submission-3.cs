public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length){
            return false;
        }
        int[] alpha = new int[26];
        for(int i = 0; i < s.Length; i++){
            alpha[s[i] - 'a']++;
            alpha[t[i] - 'a']--;
        }

        foreach(int j in alpha){
            if(j != 0){
                return false;
            }
        }
        return true;
    }
}
