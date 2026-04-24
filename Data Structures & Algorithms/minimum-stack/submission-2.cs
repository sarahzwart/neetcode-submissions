public class MinStack {
    private Stack<int> stack;
    private Stack<int> minStack;

    public MinStack() {
        // initializes the stack object
        minStack = new Stack<int>(); // one to keep track of the min element
        stack = new Stack<int>(); // one to keep track of all the elements
    }
    
    public void Push(int val) {
        // pushes the element val onto the stack
        stack.Push(val);
        val = Math.Min(val, minStack.Count == 0 ? val : minStack.Peek());
        minStack.Push(val);
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
