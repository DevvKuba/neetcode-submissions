public class MinStack {
    Stack<int> stack;
    // element : count
    Dictionary<int, int> elements = new Dictionary<int, int>();

    public MinStack()
    {
        stack = new Stack<int>();
    }

    public void Push(int val)
    {
        if(elements.ContainsKey(val))
        {
            elements[val]++;
        }
        else
        {
            elements[val] = 1;
        }

        stack.Push(val);
    }

    public void Pop()
    {
        var number = stack.Pop();
        elements[number]--;

        if (elements[number] == 0) elements.Remove(number);
    }

    public int Top()
    {
        return stack.Peek();
    }

    public int GetMin()
    {
        return elements.Min(x => x.Key);
    }
}
