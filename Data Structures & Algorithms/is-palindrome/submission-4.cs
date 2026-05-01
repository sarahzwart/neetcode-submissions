public class Solution {
    public bool IsPalindrome(string s) {
        int l = 0, r = s.Length - 1;
        while(l < r){
            while (l < r && !isAlphanumeric(s[l])){
                l++;
            }
            while (l < r && !isAlphanumeric(s[r])){
                r--;
            }
            if(char.ToLower(s[l]) != char.ToLower(s[r])){
                return false;
            }
            l++;
            r--;
        }
        return true;
    }

    public bool isAlphanumeric(char c) {
        return ((c >= 'a' && c <= 'z') ||
                (c >= 'A' && c <= 'Z') ||
                (c >= '0' && c <= '9'));
    }
}