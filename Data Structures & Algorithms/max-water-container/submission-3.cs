public class Solution {
    public int MaxArea(int[] heights) {
        Random random = new Random();
        int maxArea = 0;

        int l = 0;
        int r = heights.Length - 1;

        while(l < r)
        {
            int pointersDistance = r - l;
            int lowerstPointerHeight = heights[r] > heights[l] ? heights[l] : heights[r];

            int area = lowerstPointerHeight * pointersDistance;

            if(area > maxArea)
            {
                maxArea = area;
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
                int randomNum = random.Next(0,2);
                if(randomNum == 0)
                {
                    l++;
                }
                else
                {
                    r--;
                }
            }
        }
        return maxArea;
    }
            
}
