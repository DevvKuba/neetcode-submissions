public class Solution {
    public int Search(int[] nums, int target) {
        int l = 0, r = nums.Length - 1;

        while(l <= r)
        {
            int m = (l + r) / 2;

            if (nums[m] == target) return m;

            if (nums[l] <= nums[m]) // if we are in the left section is sorted 
            {
                if(target >= nums[l] && target <= nums[m])
                {
                    r = m - 1;
                }
                else
                {
                    l = m + 1;
                }
            }
            else  // else right is sorted 
            {
                if(target >= nums[m] && target <= nums[r])
                {
                    l = m + 1;
                }
                else
                {
                    r = m - 1;
                }
            }                
        }
        return -1;
    }
}
