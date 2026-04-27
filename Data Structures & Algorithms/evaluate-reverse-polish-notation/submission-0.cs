public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> stack = new Stack<int>();
        foreach(string c in tokens){
            if (c == "-"){
                int val1 = stack.Pop();
                int val2 = stack.Pop();
                stack.Push(val2 - val1);
            }
            else if(c == "+"){
                stack.Push(stack.Pop() + stack.Pop());
            }
            else if(c == "*"){
                stack.Push(stack.Pop() * stack.Pop());
            }
            else if(c == "/"){
                int val1 = stack.Pop();
                int val2 = stack.Pop();
                stack.Push((int)((double)val2 / val1));
            } else {
                stack.Push(int.Parse(c));
            }
        }
        return stack.Pop();
    }
}
