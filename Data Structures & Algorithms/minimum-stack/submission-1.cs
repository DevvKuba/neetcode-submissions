public class MinStack {
    
    public Stack<int> Stack { get; set; }
    
    public MinStack()
    {
        Stack = new Stack<int>();
    }

    public void Push(int val)
    {
        Stack.Push(val);
    }

    public void Pop()
    {
        Stack.Pop();
    }

    public int Top()
    {
        return Stack.Peek();
    }

    public int GetMin()
    {
        return Stack.Min(x => x);

    }
}
