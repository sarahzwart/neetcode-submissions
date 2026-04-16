public class Solution {
    public bool IsValid(string s) {
        // need Dictionary 
        // need Stack
        Stack<char> stack = new Stack<char>();
        Dictionary<char,char> brackets = new Dictionary<char, char> {
            {'{' , '}'},
            {'(' , ')'},
            {'[' , ']'}
        };
        foreach (char c in s) {
            if (brackets.ContainsKey(c)) {
                stack.Push(brackets[c]); 
            } 
            else {
                if (stack.Count == 0 || stack.Pop() != c) {
                    return false;
                }
            }
        }
        return stack.Count == 0;
    }
}
