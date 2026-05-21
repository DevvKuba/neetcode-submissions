public class Solution {
    public int FindDuplicate(int[] nums)
{
    for (int i = 0; i < nums.Length; i++)
    {
        int indx = Math.Abs(nums[i]) - 1;
        if (nums[indx] < 0)
        {
            return Math.Abs(nums[i]);
        }
        nums[indx] *= -1;

    }

    return 0;
}
}
