public class Solution {
    public int EvalRPN(string[] tokens) {
        var stack = new Stack<int>();

        foreach(string s in tokens)
        {
            if (s == "+")
            {
                var firstElem = stack.Pop();
                var secondElem = stack.Pop();

                stack.Push(secondElem + firstElem);
            }
            else if (s == "-")
            {
                var firstElem = stack.Pop();
                var secondElem = stack.Pop();

                stack.Push(secondElem - firstElem);
            }
            else if (s == "*")
            {
                var firstElem = stack.Pop();
                var secondElem = stack.Pop();

                stack.Push(secondElem * firstElem);
            }
            else if (s == "/")
            {
                var firstElem = stack.Pop();
                var secondElem = stack.Pop();

                stack.Push(secondElem / firstElem);
            }
            else
            {
                stack.Push(int.Parse(s));
            }
        }
        return stack.Pop();
    }
}
