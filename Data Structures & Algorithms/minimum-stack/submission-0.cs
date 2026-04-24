public class MinStack {
    private Stack<int> stack;
    private Stack<int> minStack;

    public MinStack() {
        // initializes the stack object
        minStack = new Stack<int>();
        stack = new Stack<int>();
    }
    
    public void Push(int val) {
        stack.Push(val);
        // pushes the element val onto the stack
        if(minStack.Count == 0){
            minStack.Push(val);
        } else {
            minStack.Push(Math.Min(minStack.Peek(), val));
        }
    }
    
    public void Pop() {
        // removes the element on the top of the stack
        minStack.Pop();
        stack.Pop();
    }
    
    public int Top() {
        // gets the top element of the stack
        return stack.Peek();
    }
    
    public int GetMin() {
        // retrieves the minimum element in the stack
        return minStack.Peek();
    }
}
