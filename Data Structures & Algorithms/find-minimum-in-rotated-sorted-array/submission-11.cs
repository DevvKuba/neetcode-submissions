public class Solution {
    public int FindMin(int[] nums)
{
    int res = nums[0];
    int l = 0, r = nums.Length - 1;

    while (l <= r)
    {

        //when arr IS sorted
        if (nums[l] <= nums[r])
        {
            res = Math.Min(res, nums[l]);
            break;
        }

        // when arr is NOT sorted
        int mid = (l + r) / 2;
        res = Math.Min(res, nums[mid]);

        if (nums[mid] >= nums[l])
        {
            // we don't want to search the left side as we know it contains 3..5 not numbers below 5
            l = mid + 1;
        }
        else if (nums[mid] < nums[l])
        {
            // we don't want to search the right side as it isn't a sorted arr, may contain our min value
            r = mid - 1;
        }

        // conditional that checks lowest val
        //if (nums[mid] < nums[l] && nums[mid] < nums[r])
        //{
        //    return nums[mid];
        //}

    }

    return res;

}
}
