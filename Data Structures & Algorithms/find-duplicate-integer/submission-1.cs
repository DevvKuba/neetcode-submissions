public class Solution {
    public int FindDuplicate(int[] nums)
{
    for (int i = 0; i < nums.Length; i++)
    {
        int negativeVal = nums[i] * -1;
        if (nums.Contains(negativeVal))
        {
            return negativeVal * -1;
        }
        nums[i] = negativeVal;

    }

    return 0;
}
}
