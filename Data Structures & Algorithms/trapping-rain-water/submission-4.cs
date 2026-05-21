public class Solution {
    public int Trap(int[] height) {
        if (height == null || height.Length == 0)
        {
            return 0;
        }

        int maxArea = 0;
        int l = 0;
        int r = height.Length - 1;

        int leftMax = height[l];
        int rightMax = height[r];

        // equasion to calculate how much water we can trap at position
        // min(l, r) - height[i]

        //IMP
        // if through the math max we update the value to new l or r
        // we don't update the maxArea 

        while(l < r)
        {
            if(leftMax < rightMax)
            {
                l++;
                leftMax = Math.Max(leftMax, height[l]);
                maxArea += leftMax - height[l];
            }
            else
            {
                r--;
                rightMax = Math.Max(rightMax, height[r]);
                maxArea += rightMax - height[r];
            }
        }
        return maxArea;
    }
}
