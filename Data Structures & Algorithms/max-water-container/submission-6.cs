public class Solution {
    public int MaxArea(int[] heights) {
        int maxArea = 0;
        
        int l = 0;
        int r = heights.Count() - 1;

        // will need a formula to calculate area

        while (l < r) {
            var distance = r - l;
            var area = Math.Min(heights[l], heights[r]) * distance;
           
            maxArea = Math.Max(maxArea, area);

            if(heights[l] < heights[r]){
                l++;
            }
            else{
                r--;
            }
        }

        return maxArea;
    }
}
