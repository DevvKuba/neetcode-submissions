public class Solution {
    public int MaxArea(int[] heights)
    {
        int maxContainer = 0;
        for (int i = 0; i < heights.Length; i++)
        {
            int l = i;
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

                r--;
            }
        }

        return maxContainer;
    }
}
