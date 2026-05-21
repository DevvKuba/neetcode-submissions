public class Solution {
    public int Search(int[] nums, int target) {
        if (nums.Count() == 0) return -1; 

        int l = 0;
        int r = nums.Count() - 1;

        while(l <= r)
        {
            var centerIndex = (r + l) / 2;

            if(target < nums[centerIndex])
            {
                r = centerIndex - 1;
            }
            else if(target > nums[centerIndex])
            {
                l = centerIndex + 1;
            }
            // last case it is the value
            else
            {
                return centerIndex;
            }
        }
        return -1;
    }
}
