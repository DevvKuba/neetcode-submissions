public class Solution {
    public bool IsValid(string s)
{
if (s.Length % 2 != 0) return false;
Stack<char> stack = new Stack<char>();
Dictionary<char, char> charDict = new Dictionary<char, char>
{
    [')'] = '(',
    [']'] = '[',
    ['}'] = '{',
};

foreach (char c in s)
{
    if (charDict.ContainsValue(c))
    {
        stack.Push(c);
    }
    else if (!charDict.ContainsValue(c))
    {
        // if this values , 'key' is the peek of the stack
        if (stack.Count == 0)
        {
            return false;
        }
        char topStackChar = stack.Pop();
        if (charDict[c] != topStackChar)
        {
            return false;
        }
    }
}
if (stack.Count != 0)
{
    return false;
}

return true;

}
}
