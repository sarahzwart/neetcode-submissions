public class Solution {
    public bool IsValid(string s) {
        var dict = new Dictionary<char,char> {
            { '}', '{' },
            { ']', '[' },
            { ')', '(' }
        };
        Stack<char> stack = new Stack<char>();
        foreach(char p in s){
            // if its a closed bracket 
            if(dict.ContainsKey(p)){
                // if the next thing popped doesnt equal the bracket
                if(stack.Count > 0 && stack.Peek() == dict[p]){
                    stack.Pop();
                } else {
                    return false;
                }
            } else {
                stack.Push(p);
            }
            
        }
        return stack.Count == 0;
    }
}
