public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        var stack = new Stack<int>();
        int[] res = new int[temperatures.Length];
        int focusIndex = 0;

        for(int i = 0; i < temperatures.Length; i++)
        {
            if(!stack.Any())
            {
                stack.Push(i);
                focusIndex = i;
            }
            else
            {
                // if new element is larger than this one we replace last index
                if (temperatures[i] > temperatures[focusIndex])
                {
                    var indexDifference = i - focusIndex;
                    res[focusIndex] = indexDifference;

                    stack.Clear();
                    i = focusIndex;
                }
                else
                {
                    stack.Push(i);
                    
                    // if we are on the last index and we end up in this case
                    if(i == temperatures.Length - 1)
                    {
                        res[focusIndex] = 0;

                        stack.Clear();
                        i = focusIndex;
                    }
                }
            }
        }
        return res;
    }
}
