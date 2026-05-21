public class Solution {
    public int MaxArea(int[] heights)
{
    int maxContainer = 0;
    int l = 0;
    int r = heights.Length - 1;
    while (l < r)
    {
        // min between the two then multiply by length between the pointers
        int length = r - l;
        int area = Math.Min(heights[l], heights[r]) * length;
        if (area > maxContainer)
        {
            maxContainer = area;
        }

        if (heights[l] < heights[r])
        {
            l++;
        }

        else if (heights[r] < heights[l])
        {
            r--;
        }
        else
        {
            l++;
        }

    }

    return maxContainer;
}
}
