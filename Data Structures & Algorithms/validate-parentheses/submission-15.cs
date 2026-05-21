public class Solution {
    public bool IsValid(string s) {
        var parenthesesDict = new Dictionary<char, char>
        {
            { '(', ')' },
            { '[', ']' },
            { '{', '}' }
        };

        var stack = new Stack<char>();

        foreach(char c in s){
            if (parenthesesDict.ContainsValue(c) && stack.Count > 0)
            {
                // check in stack
                var topParenthesis = stack.Pop();
                if(topParenthesis != c)
                {
                    return false;
                }
            }
             else if(parenthesesDict.ContainsKey(c))
            {
                stack.Push(parenthesesDict[c]);
            }
            else
            {
                return false;
            }
        }

        if (stack.Count > 0) return false;
        return true;
    }
}
