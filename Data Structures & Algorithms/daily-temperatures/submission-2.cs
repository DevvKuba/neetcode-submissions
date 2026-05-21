public class Solution {
   public int[] DailyTemperatures(int[] temperatures)
{
    int[] res = new int[temperatures.Count()];
    Stack<int> stack = new Stack<int>();

    for (int i = 0; i < temperatures.Length; i++)
    {
        int t = temperatures[i];
        while (stack.Count > 0 && t > temperatures[stack.Peek()])
        {
            int peekIndex = stack.Pop();
            res[peekIndex] = i - peekIndex;
        }
        stack.Push(i);

    }

    return res;

}
}
