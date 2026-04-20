public class Solution {
    public bool IsPalindrome(string s) {
        // I need to parse every char
        // ignore spaces
        // two pointera
        int l = 0, r = s.Length - 1;
        while(l < r){
            while(l < r && !isAlphanumeric(s[l])){
                l++;
            }
            while(r > l && !isAlphanumeric(s[r])){
                r--;
            }
            if(Char.ToLower(s[r]) != Char.ToLower(s[l])){
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