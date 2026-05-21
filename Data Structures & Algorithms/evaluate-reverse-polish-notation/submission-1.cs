public class Solution {
    public int EvalRPN(string[] tokens)
{
    // append eveyrthing to stack , if an arithmetic operator pops up
    // then use it on the values in the stack, then push the result

    Stack<int> stack = new Stack<int>();

    for (int i = 0; i < tokens.Length; i++)
    {
        if (tokens[i] == "+")
        {
            int value1 = stack.Pop();
            int value2 = stack.Pop();
            int res = value2 + value1;
            stack.Push(res);
        }
        else if (tokens[i] == "-")
        {
            int value1 = stack.Pop();
            int value2 = stack.Pop();
            int res = value2 - value1;
            stack.Push(res);
        }
        else if (tokens[i] == "*")
        {
            int value1 = stack.Pop();
            int value2 = stack.Pop();
            int res = value2 * value1;
            stack.Push(res);
        }
        else if (tokens[i] == "/")
        {
            int value1 = stack.Pop();
            int value2 = stack.Pop();
            int res = value2 / value1;
            stack.Push(res);
        }
        else
        {
            stack.Push(int.Parse(tokens[i]));
        }
    }

    return stack.Pop();

}
}
